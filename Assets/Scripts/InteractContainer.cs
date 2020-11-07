using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class InteractContainer : MonoBehaviour, IInit
{
    private InteractableItem[] items;
    private List<InteractableItem> selectedItems;
    private List<InteractableItem> otherItems;

    public List<InteractableItem> SelectedItems => selectedItems;
    public List<InteractableItem> OtherItems => otherItems;

    public void INIT()
    {
        selectedItems = new List<InteractableItem>();
        otherItems = new List<InteractableItem>();
    }

    public void GET()
    {
        //TODO: Заменить
        items = FindObjectsOfType<InteractableItem>();
    }

    public void AFTER_INIT()
    {
        for (int i = 0; i < items.Length; i++)
        {
            var temp = items[i];
            var select = Random.Range(0, items.Length);
            items[i] = items[select];
            items[select] = temp;
        }

        for (int i = 0; i < items.Length; i++)
        {
            if (i < 6)
            {
                selectedItems.Add(items[i]);
                items[i].isAvable = true;
            }
            else
            {
                otherItems.Add(items[i]);
            }
        }
    }

    private InteractableItem otherItemPop()
    {
        InteractableItem temp = otherItems[0];
        otherItems.Remove(temp);
        for (int i = 0; i < otherItems.Count; i++)
        {
            var randindex = Random.Range(0, otherItems.Count);
            
            var sorttemp = otherItems[i];
            otherItems[i] = otherItems[randindex];
            otherItems[randindex] = sorttemp;
        }
        return temp;
    }

    public void Next(InteractableItem previousItem)
    {
        CanvasScript.current.stationsPanel.updateItems();
        
        previousItem.isAvable = false;
        selectedItems.Remove(previousItem);

        InteractableItem nextItem = otherItemPop();
        selectedItems.Add(nextItem);
        otherItems.Add(previousItem);
        nextItem.isAvable = true;
        
    }
}
