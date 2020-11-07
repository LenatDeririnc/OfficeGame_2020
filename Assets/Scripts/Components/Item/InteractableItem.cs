using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Debug = UnityEngine.Debug;

public class InteractableItem : Item, IInit
{
    #region init
    private GameObject m_gameObject;
    private IEnumerator DegreseHealth;
    private bool m_isAwableForTerminal;
    [SerializeField] private bool m_isAvable = true;
    private StationStatus m_currentStatus;
    private IEnumerator m_interactCorutine;

    #endregion

    #region parameters
    
    [SerializeField] private string m_id = "";
    private float m_health;
    [SerializeField] private float startHealth = 600;
    [SerializeField] private float m_maxHealth = 100;
    [SerializeField] private float m_changeHealthSpeed = 1;
    [SerializeField] private float m_greenZone = 75;
    [SerializeField] private float m_redZone = 25;
    [SerializeField] private string m_command = "";
    [SerializeField] private string m_logMessage;
    [SerializeField] public float m_interactSpeed = 1f;

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
        set => m_health = Mathf.Clamp(value, 0, maxHealth);
    }

    public StationStatus CurrentStatus
    {
        get => m_currentStatus;
        set
        {
            if (m_currentStatus == value) return;
            m_currentStatus = value;
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
        DegreseHealth = HealthDegreaseCoroutine();
        StartCoroutine(DegreseHealth);
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        m_health = startHealth;
        m_isAvable = true;
        HideObject();
    }

    public void setCurrentStatus()
    {
        switch (health)
        {
            default:
                CurrentStatus = StationStatus.Great;
                CanvasScript.current.winPanel.AppendGoodSector(this);
                break;
            case float h when (m_redZone < h && h <= m_greenZone):
                CurrentStatus = StationStatus.Ok;
                CanvasScript.current.winPanel.RemoveGoodSector(this);
                break;
            case float h when (0 < h && h <= m_redZone):
                CurrentStatus = StationStatus.Bad;
                CanvasScript.current.winPanel.RemoveGoodSector(this);
                CanvasScript.current.gameOverTimer.StartTimer(this);
                break;
            case float h when (h == 0):
                CurrentStatus = StationStatus.Died;
                CanvasScript.current.winPanel.RemoveGoodSector(this);
                CanvasScript.current.gameOverTimer.StartTimer(this);
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
            Interact();
    }

    public void StopTimer()
    {
        StopCoroutine(DegreseHealth);
    }

    public void ShowObject()
    {
        m_gameObject.SetActive(true);
        StartCoroutine(DegreseHealth);
        m_isAvable = true;
    }

    public void HideObject()
    {
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

    public void InteractActions()
    {
        m_health = startHealth;
        CanvasScript.current.gameOverTimer.StopTimer(this);
        GameManager.current.interactContainer.Next(this);
    }

    private IEnumerator HealthDegreaseCoroutine()
    {
        while (true)
        {
            health -= m_changeHealthSpeed;
            yield return new WaitForSeconds(0.1f);
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
        setCurrentStatus();
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