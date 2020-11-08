using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour, IInit
{
    public static CanvasScript current;
    public InputPanelScript inputPanel;
    public InteractPanelScript interactPanel;
    public GachaPanel gachaPanel;
    public CommandsPanel commandsPanel;
    public StationsPanel stationsPanel;
    public GameOverTimer gameOverTimer;
    public GameOverPanel gameOverPanel;
    public WinPanel winPanel;
    public InteractProgressBar interactProgressBar;
    public StressLevel stressLevel;

    private List<IInit> INIT_ORDER;

    private void FILL_INIT_ORDER()
    {
        INIT_ORDER = new List<IInit>();
        INIT_ORDER.Add(inputPanel);
        INIT_ORDER.Add(interactPanel);
        INIT_ORDER.Add(gachaPanel);
        INIT_ORDER.Add(stressLevel);
        INIT_ORDER.Add(commandsPanel);
        INIT_ORDER.Add(stationsPanel);
        INIT_ORDER.Add(gameOverTimer);
        INIT_ORDER.Add(gameOverPanel);
        INIT_ORDER.Add(winPanel);
        INIT_ORDER.Add(interactProgressBar);
    }
    
    public void INIT()
    {
        current = this;
        FILL_INIT_ORDER();

        foreach (var initElement in INIT_ORDER)
        {
            initElement.INIT();
        }
    }

    public void GET()
    {
        foreach (var initElement in INIT_ORDER)
        {
            initElement.GET();
        }
    }

    public void AFTER_INIT()
    {
        foreach (var initElement in INIT_ORDER)
        {
            initElement.AFTER_INIT();
        }
    }
}
