using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Commands : MonoBehaviour
{
    private Dictionary<string, Action> CommandLibary;
    public InputPanelScript inputPanel;

    public void Awake()
    {
        CommandLibary = new Dictionary<string, Action>();
        CommandLibary.Add("test", Helloworld);
    }

    public void CheckCommand(string[] args)
    {
        if (CommandLibary.ContainsKey(args[0])) CommandLibary[args[0]].Invoke();
    }

    private void Helloworld()
    {
        inputPanel.WriteToConsole("Hello world!");
    }
    
    private void Take(string item)
    {
        Debug.Log("test");
    }
}
