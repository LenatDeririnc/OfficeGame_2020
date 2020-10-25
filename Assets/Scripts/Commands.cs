using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Commands : MonoBehaviour
{
    private Dictionary<string, Action<string[]>> CommandLibary;
    public InputPanelScript inputPanel;

    public void Awake()
    {
        CommandLibary = new Dictionary<string, Action<string[]>>();
        CommandLibary.Add("test", Helloworld);
        CommandLibary.Add("take", Take);
    }

    public void CheckCommand(string[] args)
    {
        if (CommandLibary.ContainsKey(args[0])) CommandLibary[args[0]].Invoke(args);
    }

    private void Helloworld(string[] args)
    {
        inputPanel.WriteToConsole("Hello world!");
    }
    
    private void Take(string[] args)
    {
        if (args.Length <= 1) return;
        
        Item[] items = GameObject.FindObjectsOfType<Item>();
        foreach (Item item in items)
        {
            if (item.ID() == args[1])
            {
                item.Interact();
                break;
            }
        }
    }
}
