using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Debug = UnityEngine.Debug;

public class InteractableItem : Item
{
    #region init
    private GameObject m_gameObject;
    private IEnumerator DegreseHealth;
    private bool m_isActive;
    private StationStatus m_currentStatus;

    #endregion

    #region parameters
    
    [SerializeField] private string m_id = "";
    [SerializeField] private float m_health;
    [SerializeField] private float m_maxHealth = 100;
    [SerializeField] private float m_changeHealthSpeed = 1;
    [SerializeField] private float m_greenZone = 75;
    [SerializeField] private float m_redZone = 25;
    [SerializeField] private string m_command = "";
    [SerializeField] private string m_logMessage;

    #endregion

    #region properties
    public override string ID() => m_id;
    public string logMessage => m_logMessage;
    public string command => m_command.ToLower();
    public bool isActive => m_isActive;
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
            Debug.Log(m_currentStatus.ToString());
        }
    }

    public float maxHealth => m_maxHealth;
    public override string InteractName() => "Использовать";
    public Action InteractWithCommand() => CommandInteract;
    #endregion

    #region logic

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
                CanvasScript.current.gameOverTimer.StartTimer(this);
                break;
            case float h when (h == 0):
                CurrentStatus = StationStatus.Died;
                CanvasScript.current.gameOverTimer.StartTimer(this);
                break;
        }
    }

    public void setActive()
    {
        m_isActive = true;
    }

    private void CommandInteract()
    {
        if (m_isActive)
            Interact();
    }

    private void Awake()
    {
        m_gameObject = gameObject;
        DegreseHealth = HealthDegreaseCoroutine();
    }

    private void Start()
    {
        m_health = m_maxHealth;
        StartCoroutine(DegreseHealth);
    }

    public override void Interact()
    {
        m_health = maxHealth;
        CanvasScript.current.gameOverTimer.StopTimer(this);
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