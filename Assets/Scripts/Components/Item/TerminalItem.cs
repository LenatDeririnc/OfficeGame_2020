using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalItem : Item
{
    [SerializeField] private string m_id = "";
    private string m_interactName = "Использовать";

    public override string ID() => m_id;

    public override string InteractName() => m_interactName;

    public override void Interact()
    {
        CanvasScript.current.inputPanel.SwitchToCommandMode();
    }
}
