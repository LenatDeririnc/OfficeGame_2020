using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameEvents : MonoBehaviour, IInit
{
    public static GameEvents current;

    public void INIT()
    {
        current = this;
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        // throw new NotImplementedException();
    }

    private void Awake()
    {
        INIT();
        GET();
        AFTER_INIT();
    }
}
