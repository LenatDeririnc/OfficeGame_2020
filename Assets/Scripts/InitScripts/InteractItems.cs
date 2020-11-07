using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractItems : MonoBehaviour, IInit
{
    public static InteractItems current;
    private TerminalItem[] terminals;


    public void INIT()
    {
        current = this;
        terminals = GetComponentsInChildren<TerminalItem>();
        foreach (var terminal in terminals)
        {
            terminal.INIT();
        }
    }

    public void GET()
    {
        foreach (var terminal in terminals)
        {
            terminal.GET();
        }
    }

    public void AFTER_INIT()
    {
        foreach (var terminal in terminals)
        {
            terminal.AFTER_INIT();
        }
    }
}
