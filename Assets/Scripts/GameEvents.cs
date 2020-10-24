using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    public InputPanelScript InputPanelScript;

    private void Awake()
    {
        current = this;
    }

    public event Action onCommandModeActivated;
    public void CommandModeActivated()
    {
        if (onCommandModeActivated != null)
        {
            onCommandModeActivated();
        }
    }
    
    public event Action onCommandModeExited;
    public void CommandModeExited()
    {
        if (onCommandModeExited != null)
        {
            onCommandModeExited();
        }
    }

}
