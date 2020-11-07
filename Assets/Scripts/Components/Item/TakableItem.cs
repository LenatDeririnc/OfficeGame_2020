using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakableItem : Item, IInit
{
    private GameObject m_gameObject;
    [SerializeField] private string m_id = "";

    public override string ID() => m_id;

    public override string InteractName() => "Взять";

    public override void Interact() => m_gameObject.SetActive(false);

    public void INIT()
    {
        m_gameObject = gameObject;
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        // throw new NotImplementedException();
    }
}
