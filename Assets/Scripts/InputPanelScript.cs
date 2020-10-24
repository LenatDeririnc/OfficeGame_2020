using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputPanelScript : MonoBehaviour
{
    #region INIT
    
    public bool CommandModeActivated = false;
    public GameObject fieldObject;
    public TMP_Text logField;
    public TMP_InputField inputField;
    public event Action onConsoleUpdate;

    private void INIT()
    {
        GameEvents.current.onCommandModeActivated += SwitchToCommandMode;
        GameEvents.current.onCommandModeExited += SwitchFromCommandMode;
        fieldObject.SetActive(CommandModeActivated);
    }

    private void Awake()
    {
        INIT();
        _typingLog = logField.text;
    }

    #endregion

    #region FIELDS

    public string typingLine;

    private string _typingLog;
    
    private string typingLog
    {
        get => _typingLog;
        set => _typingLog = _typingLog + "\n" + value + " ";
    }

    #endregion

    #region LOGIC

    public void SwitchToCommandMode()
    {
        fieldObject.SetActive(true);
        inputField.ActivateInputField();
    }

    public void SwitchFromCommandMode()
    {
        fieldObject.SetActive(false);
        clearTypeLine();        
    }

    public void clearTypeLine()
    {
        inputField.text = "";
        typingLine = "";
    }

    public void type(string value)
    {
        typingLine = value;
    }
    
    public void acceptTyping()
    {
        typingLog = typingLine;
        logField.text = typingLog;
        GameManager.current.commands.CheckCommand(typingLine.Split(' '));
        typingLine = "";
        clearTypeLine();
        inputField.ActivateInputField();
    }

    public void WriteToConsole(string value)
    {
        typingLog = value;
        logField.text = typingLog;
    }

    #endregion
    
}
