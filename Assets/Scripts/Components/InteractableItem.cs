using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : Item
{
    [SerializeField] private string m_id = "";
    [SerializeField] private float m_health = 100;
    [SerializeField] private float m_changeHealthSpeed = 1;

    public float Health
    {
        get => m_health;
        set => m_health = Mathf.Clamp(value, 0, 100);
    }

    private void HealthDegrease()
    {
        Health -= Time.deltaTime * m_changeHealthSpeed;

        if (Health == 0)
        {
            Destroy(gameObject);
        }
    }

    public override string ID() => m_id;

    public override void Interact()
    {
        m_health = 100f;
    }

    private void Update()
    {
        HealthDegrease();
    }
}
