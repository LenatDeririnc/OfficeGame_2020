using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Commands : MonoBehaviour
{
    private InteractableItem[] items;
    
    public static Commands current;
    private Dictionary<string, InteractableItem> CommandLibary;
    public InputPanelScript inputPanel;

    public void Awake()
    {
        current = this;
        items = GameObject.FindObjectsOfType<InteractableItem>();
        CommandLibary = new Dictionary<string, InteractableItem>();
    }

    private void Start()
    {
        foreach (InteractableItem item in items)
        {
            addCommand(item);
        }
    }

    private void addCommand(InteractableItem item)
    {
        string command = item.command;
        string logMessage = item.logMessage;
        Action action = item.InteractWithCommand();
        
        if (command != null)
        {
            if (action != null) CommandLibary.Add(command, item);
        }
    }

    public void CheckCommand(string args)
    {
        string newArgs = args.ToLower();
        if (CommandLibary.ContainsKey(newArgs))
        {
            InteractableItem current = CommandLibary[newArgs];

            bool isActive = current.isActive;
            string command = current.command;
            string logMessage = current.logMessage;
            Action action = current.InteractWithCommand();
            
            if (!isActive) return;
            if (action != null) action();
            if (logMessage != null) ShowMessage(logMessage);
        }
    }

    private void ShowMessage(string message)
    {
        inputPanel.WriteToConsole(message);
    }
}
