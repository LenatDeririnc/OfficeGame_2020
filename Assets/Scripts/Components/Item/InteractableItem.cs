using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : Item
{
    #region init
    private GameObject m_gameObject;
    private IEnumerator DegreseHealth;

    #endregion

    #region parameters
    
    [SerializeField] private string m_id = "";
    [SerializeField] private float m_health;
    [SerializeField] private float m_maxHealth = 100;
    [SerializeField] private float m_changeHealthSpeed = 1;
    [SerializeField] private string m_command = "";
    [SerializeField] private bool m_isActive;
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
        set => m_health = Mathf.Clamp(value, 0, 100);
    }

    public float maxHealth => m_maxHealth;
    public override string InteractName() => "Использовать";
    public Action InteractWithCommand() => CommandInteract;
    #endregion

    #region logic

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
        m_health = 100f;
    }

    private IEnumerator HealthDegreaseCoroutine()
    {
        while (true)
        {
            health -= m_changeHealthSpeed;
            if (health == 0)
            {
                m_gameObject.SetActive(false);
                break;
            }
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
    
    #endregion
}
