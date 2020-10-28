using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public static CanvasScript current;
    public InputPanelScript inputPanel;
    public InteractPanelScript interactPanel;
    public GachaPanel gachaPanel;
    public CommandsPanel commandsPanel;
    public StationsPanel stationsPanel;

    private void Awake()
    {
        current = this;
    }
}
