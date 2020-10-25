using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakableItem : Item
{
    [SerializeField] private string m_id = "";
    public override string ID() => m_id;
    
    [SerializeField] private string message = "";
    public override void Interact()
    {
        Destroy(gameObject);
    }
}
