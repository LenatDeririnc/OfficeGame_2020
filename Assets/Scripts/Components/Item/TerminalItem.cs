using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalItem : Item, IInit
{
    [SerializeField] private string m_id = "";
    private string m_interactName = "Использовать";

    public override string ID() => m_id;

    public override string InteractName() => m_interactName;

    private InputPanelScript _inputPanel;

    public void INIT()
    {
        
    }

    public void GET()
    {
        _inputPanel = CanvasScript.current.inputPanel;
    }

    public void AFTER_INIT()
    {
        
    }

    public override void Interact()
    {
        if (_inputPanel != null)
        {
            _inputPanel.SwitchToCommandMode();
            return;
        }
        else
        {
            CanvasScript.current.inputPanel.SwitchToCommandMode();
        }
    }
}
