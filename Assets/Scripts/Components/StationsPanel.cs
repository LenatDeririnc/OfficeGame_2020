using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class StationsPanel : MonoBehaviour
{
    private TMP_Text text;
    private string currentText;
    private InteractableItem[] items;
    private Dictionary<StationStatus, string> colorStatus;

    private void initColors()
    {
        colorStatus = new Dictionary<StationStatus, string>();
        colorStatus.Add(StationStatus.Great, "<color=\"green\">");
        colorStatus.Add(StationStatus.Ok, "<color=#FFCC67>");
        colorStatus.Add(StationStatus.Bad, "<color=\"red\">");
        colorStatus.Add(StationStatus.Died, "<color=\"black\">");
    }
    
    private void Awake()
    {
        initColors();
        text = GetComponentInChildren<TMP_Text>();
        text.text = "";
        items = FindObjectsOfType<InteractableItem>();
    }

    void updateValues()
    {
        string outString = "Станции\n";
        outString += "-----------\n";

        foreach (InteractableItem item in items)
        {
            string itemStatus = colorStatus[item.CurrentStatus];
            string timeString = item.health > 0 ? string.Format("{0000, 3:###}", item.health) : "  0";
            
            outString += itemStatus + item.ID() + "\t - " + timeString + "/" + item.maxHealth + "\n";
        }
        text.text = outString;
    }

    void Update()
    {
        updateValues();
    }
    
}
