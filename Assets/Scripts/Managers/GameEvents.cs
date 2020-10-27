using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    public InputPanelScript InputPanelScript;

    private void Awake()
    {
        current = this;
    }

}
