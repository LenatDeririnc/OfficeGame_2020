using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakableItem : Item
{
    private GameObject m_gameObject;
    [SerializeField] private string m_id = "";

    public override string ID() => m_id;

    public override string InteractName() => "Взять";

    private void Awake() => m_gameObject = gameObject;

    public override void Interact() => m_gameObject.SetActive(false);
}
