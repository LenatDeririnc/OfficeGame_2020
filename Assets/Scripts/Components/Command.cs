
using System;
using UnityEngine;

public struct Command
{
    private bool m_active;
    private string m_name;
    private string m_logMessage;
    private Action m_action;

    public bool isActive => m_active;
    public string name => m_name.ToLower();
    public string logMessage => m_logMessage;
    public Action action => m_action;

    public Command(string name, string logMessage, Action action)
    {
        m_name = name;
        m_logMessage = logMessage;
        m_action = action;
        m_active = false;
    }

    public Command(string name, string logMessage)
    {
        m_name = name;
        m_logMessage = logMessage;
        m_action = null;
        m_active = false;
    }

    public void setActive()
    {
        Debug.Log(("command:", m_name, m_logMessage, m_action));
        m_active = true;
    }
}
