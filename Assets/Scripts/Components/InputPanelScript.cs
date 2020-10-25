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
    public TMP_Text logField;
    public TMP_InputField inputField;

    private void INIT()
    {
        gameObject.SetActive(CommandModeActivated);
    }

    private void Awake()
    {
        INIT();
        _typingLog = logField.text;
    }

    public void SetActive(bool state)
    {
        gameObject.SetActive(state);
    }

    #endregion

    #region FIELDS

    private string typingLine;

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
        gameObject.SetActive(true);
        inputField.ActivateInputField();
    }

    public void SwitchFromCommandMode()
    {
        gameObject.SetActive(false);
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
        Commands.current.CheckCommand(typingLine.Split(' '));
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
