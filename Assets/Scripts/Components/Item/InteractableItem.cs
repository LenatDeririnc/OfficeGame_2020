using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class InteractableItem : Item, IInit
{
    #region init
    private bool m_isAvable = true;
    private GameObject m_gameObject;
    private IEnumerator DegreseHealth;
    private bool m_isAwableForTerminal;
    private StationStatus m_currentStatus;
    private IEnumerator m_interactCorutine;
    private bool isInited = false;
    private float m_health;
    private GameObject _smallDotGameObject;
    private GameObject _bigDotGameObject;


    #endregion

    #region parameters
    
    [SerializeField] private SpriteRenderer _smallDot;
    [SerializeField] private SpriteRenderer _bigDot;
    [SerializeField] private StationPanelItem _stationPanelItem;
    [Space]
    [SerializeField] private Color GreatColor;
    [SerializeField] private Color OkColor;
    [SerializeField] private Color BadColor;
    [SerializeField] private Color DiedColor;
    [Space]
    [SerializeField] private string m_id = "";
    [Space]
    [SerializeField] public float m_interactSpeed = 1f;
    [Space]
    [SerializeField] private float startHealth = 600;
    [SerializeField] private float m_maxHealth = 100;
    [SerializeField] private float m_repairHealth = 1000;
    [SerializeField] private float m_changeHealthSpeed = 1;

    [Space]
    [SerializeField] private float m_greenZone = 75;
    [SerializeField] private float m_redZone = 25;
    [Space] 
    [SerializeField] private float ok_flickiring_time = .5f;
    [SerializeField] private float bad_flickiring_time = .25f;
    [Space]
    [SerializeField] private string m_command = "";
    [Space]
    [SerializeField] [TextArea] private string m_logMessage;

    #endregion

    #region properties
    public override string ID() => m_id;
    public string logMessage => m_logMessage;
    public string command => m_command.ToLower();
    public bool isAwableForTerminal => m_isAwableForTerminal;
    public bool isAvable
    {
        get => m_isAvable;
        set
        {
            if (value == m_isAvable) return;
            m_isAvable = value;
            if (m_isAvable == true)
            {
                ShowObject();
            }
            else
            {
                HideObject();
            }
        }
    }

    public float health
    {
        get => m_health;
        set
        {
            m_health = Mathf.Clamp(value, 0, maxHealth);
            _stationPanelItem.ConvertToProgressValue(m_health, 0, maxHealth);
        }
    }

    public StationStatus CurrentStatus
    {
        get => m_currentStatus;
        set
        {
            if (m_currentStatus == value) return;
            m_currentStatus = value;
            OnStationStatusChanged();
        }
    }

    public float maxHealth => m_maxHealth;

    public override string InteractName() => "Использовать";

    public Action InteractWithCommand() => CommandInteract;

    #endregion

    #region logic

    public void INIT()
    {
        m_gameObject = gameObject;
        _smallDotGameObject = _smallDot.gameObject;
        _bigDotGameObject = _bigDot.gameObject;
        DegreseHealth = HealthDegreaseCoroutine();
        StartCoroutine(DegreseHealth);
    }

    public void GET()
    {
        
    }

    public void AFTER_INIT()
    {
        m_health = startHealth;
        m_isAvable = true;
        isInited = true;
        HideObject();
    }
    
    private IEnumerator FlickiringVar;
    IEnumerator Flickiring(float perSeconds)
    {
        while (true)
        {
            _bigDotGameObject.SetActive(true);
            yield return new WaitForSeconds(perSeconds);
            _bigDotGameObject.SetActive(false);
            yield return new WaitForSeconds(perSeconds);
        }
    }

    private void SetMinimapStatusDefaults(bool isSmallFirst, Color color, bool isFlickiring, float flickiringPerSeconds)
    {
        if (FlickiringVar != null) StopCoroutine(FlickiringVar);
        _smallDot.color = color;
        _bigDot.color = color;
        if (!isFlickiring)
        {
            _smallDotGameObject.SetActive(isSmallFirst);
            _bigDotGameObject.SetActive(!isSmallFirst);
        }
        else
        {
            FlickiringVar = Flickiring(flickiringPerSeconds);
            StartCoroutine(FlickiringVar);
        }
    }

    public void SetMinimapStatus(StationStatus status)
    {
        switch (status)
        {
            case StationStatus.Great:
                SetMinimapStatusDefaults(true, GreatColor, false, 0);
                break;
            case StationStatus.Ok:
                SetMinimapStatusDefaults(true, OkColor, true, ok_flickiring_time);
                break;
            case StationStatus.Bad:
                SetMinimapStatusDefaults(true, BadColor, true, bad_flickiring_time);
                break;
            case StationStatus.Died:
                SetMinimapStatusDefaults(false, DiedColor, false, 0);
                break;
        }
    }

    public void OnStationStatusChanged()
    {
        SetMinimapStatus(CurrentStatus);
        CanvasScript.current.stressLevel.CheckCurrentBalls(this);
        CanvasScript.current.stationsPanel.updateItems();
    }
    
    public void setCurrentStatus()
    {
        switch (health)
        {
            default:
                CurrentStatus = StationStatus.Great;
                break;
            case float h when (m_redZone < h && h <= m_greenZone):
                CurrentStatus = StationStatus.Ok;
                break;
            case float h when (0 < h && h <= m_redZone):
                CurrentStatus = StationStatus.Bad;
                break;
            case float h when (h == 0):
                CurrentStatus = StationStatus.Died;
                break;
        }
    }

    public void setAwableForTerminal()
    {
        m_isAwableForTerminal = true;
    }

    private void CommandInteract()
    {
        if (m_isAwableForTerminal)
            InteractActions(true);
    }

    public void StopTimer()
    {
        StopCoroutine(DegreseHealth);
    }

    public void StartTimer()
    {
        StartCoroutine(DegreseHealth);
    }

    public void ShowObject()
    {
        m_gameObject.SetActive(true);
        _stationPanelItem.ShowObject();
        StartCoroutine(DegreseHealth);
        m_isAvable = true;
    }

    public void HideObject()
    {
        _stationPanelItem.HideObject();
        StopCoroutine(DegreseHealth);
        m_isAvable = false;
        m_gameObject.SetActive(false);
    }

    public void SendInteractSignal()
    {
        CanvasScript.current.interactProgressBar.StartProgress(this);
    }

    public override void Interact()
    {
        SendInteractSignal();
    }

    public void InteractActions(bool usedWithTerminal)
    {
        m_health = m_repairHealth;
        CanvasScript.current.stressLevel.PowerUpLevel(CurrentStatus, usedWithTerminal);
        setCurrentStatus();
        GameManager.current.interactContainer.Next(this);
    }

    private IEnumerator HealthDegreaseCoroutine()
    {
        while (true)
        {
            health -= m_changeHealthSpeed * Time.deltaTime;
            yield return null;
        }
    }


    public void SetCoroutineStatus(bool status)
    {
        if (status)
        {
            StartCoroutine(DegreseHealth);
            return;
        }
        StopCoroutine(DegreseHealth);
    }

    private void Update()
    {
        if (isInited)
        {
            setCurrentStatus();
        }
    }

    #endregion
}

public enum StationStatus
{
    Great,
    Ok,
    Bad,
    Died
}