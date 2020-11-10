using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicalStationsPanel : MonoBehaviour, IInit
{
    [SerializeField] private StationPanelItem[] items;

    public void INIT()
    {
        foreach (var class_to_init in items)
        {
            class_to_init.INIT();
        }
    }

    public void GET()
    {
        foreach (var class_to_init in items)
        {
            class_to_init.GET();
        }
    }

    public void AFTER_INIT()
    {
        foreach (var class_to_init in items)
        {
            class_to_init.AFTER_INIT();
        }
    }
}
