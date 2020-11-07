using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class StationsPanel : MonoBehaviour, IInit
{
    private TMP_Text text;
    private string currentText;
    private InteractContainer _container;
    [SerializeField] private List<InteractableItem> items;
    private Dictionary<StationStatus, string> colorStatus;

    private void initColors()
    {
        colorStatus = new Dictionary<StationStatus, string>();
        colorStatus.Add(StationStatus.Great, "<color=\"green\">");
        colorStatus.Add(StationStatus.Ok, "<color=#FFCC67>");
        colorStatus.Add(StationStatus.Bad, "<color=\"red\">");
        colorStatus.Add(StationStatus.Died, "<color=\"black\">");
    }

    public void INIT()
    {
        initColors();
        text = GetComponentInChildren<TMP_Text>();
    }

    public void GET()
    {
        _container = GameManager.current.interactContainer;
        items = _container.SelectedItems;
    }

    public void AFTER_INIT()
    {
        text.text = "";
    }

    public void updateItems()
    {
        items = _container.SelectedItems;
    }

    void updateValues()
    {
        string outString = "Станции\n";
        outString += "-----------\n";

        foreach (InteractableItem item in items)
        {
            if (!item.isAvable) continue;
            
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
