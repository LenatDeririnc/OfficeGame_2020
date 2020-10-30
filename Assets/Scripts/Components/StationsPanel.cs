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

    private void createColors()
    {
        colorStatus = new Dictionary<StationStatus, string>();
        colorStatus.Add(StationStatus.Great, "<color=\"green\">");
        colorStatus.Add(StationStatus.Ok, "<color=#FFCC67>");
        colorStatus.Add(StationStatus.Bad, "<color=\"red\">");
        colorStatus.Add(StationStatus.Died, "<color=\"black\">");
    }
    
    private void Awake()
    {
        createColors();
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
            var itemStatus = colorStatus[item.CurrentStatus];
            outString += itemStatus + item.ID() + " - " + item.health + "/" + item.maxHealth + "\n";
        }
        text.text = outString;
    }

    void Update()
    {
        updateValues();
    }
    
}
