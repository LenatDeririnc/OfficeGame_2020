using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class StationsPanel : MonoBehaviour
{
    private TMP_Text text;
    private string currentText;
    private InteractableItem[] items;

    private void Awake()
    {
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
            outString += item.name + " - " + item.health + "/" + item.maxHealth + "\n";
        }
        text.text = outString;
    }

    void Update()
    {
        updateValues();
    }
    
}
