using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputPanelScript : MonoBehaviour
{
    public GameObject inputField;

    private void Start()
    {
        GameEvents.current.onCommandModeActivated += OnCommandModeActivated;
        GameEvents.current.onCommandModeExited += OnCommandModeExited;
    }

    private void OnCommandModeActivated()
    {
        inputField.SetActive(true);
    }
    
    private void OnCommandModeExited()
    {
        inputField.SetActive(false);
    }
}
