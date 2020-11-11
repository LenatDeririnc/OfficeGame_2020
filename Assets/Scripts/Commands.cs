using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Commands : MonoBehaviour, IInit
{
    private InteractableItem[] items;
    
    public static Commands current;
    private Dictionary<string, InteractableItem> CommandLibary;
    public InputPanelScript inputPanel;

    public void INIT()
    {
        current = this;
        CommandLibary = new Dictionary<string, InteractableItem>();
    }

    public void GET()
    {
        //TODO: заменить
        items = FindObjectsOfType<InteractableItem>();
    }

    public void AFTER_INIT()
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

    public void CheckCommandInLibary(string args)
    {
        string newArgs = args.ToLower();
        if (CommandLibary.ContainsKey(newArgs))
        {
            InteractableItem current = CommandLibary[newArgs];
            Debug.Log(args);
            if (!current.isAvable) return;
            
            bool isActiveForTerminal = current.isAwableForTerminal;
            string command = current.command;
            string logMessage = current.logMessage;
            Action action = current.InteractWithCommand();

            if (!isActiveForTerminal) return;
            if (action != null) action();
            if (logMessage != null) ShowMessage(logMessage);
        }
    }
    
    public void CheckCommand(string args)
    {
        string newArgs = args.ToLower();

        if (newArgs.Split(' ')[0] == "bash")
        {
            var foundNotes = NotesScript.current.foundNotes;
            foreach (var note in foundNotes)
            {
                CheckCommandInLibary(note.command);
            }
        }
        else
        {
            CheckCommandInLibary(newArgs);
        }
    }

    private void ShowMessage(string message)
    {
        inputPanel.WriteToConsole(message);
    }
}
