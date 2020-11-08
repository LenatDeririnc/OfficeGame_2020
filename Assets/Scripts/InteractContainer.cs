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
    
    private InteractableItem OtherItems_Pop()
    {
        InteractableItem temp = otherItems[0];
        otherItems.Remove(temp);
        for (int i = 0; i < otherItems.Count; i++)
        {
            int randindex = Random.Range(0, otherItems.Count);
            
            InteractableItem sorttemp = otherItems[i];
            otherItems[i] = otherItems[randindex];
            otherItems[randindex] = sorttemp;
        }
        return temp;
    }

    public void INIT()
    {
        selectedItems = new List<InteractableItem>();
        otherItems = new List<InteractableItem>();
    }

    public void GET()
    {
        items = BallsScripts.current.Balls;
    }

    private void RefreshItemsOrder()
    {
        for (int i = 0; i < items.Length; i++)
        {
            var temp = items[i];
            var select = Random.Range(0, items.Length);
            items[i] = items[select];
            items[select] = temp;
        }
    }

    private void SelectItems()
    {
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

    public void AFTER_INIT()
    {
        RefreshItemsOrder();
        SelectItems();
    }

    public void Next(InteractableItem previousItem)
    {
        CanvasScript.current.stationsPanel.updateItems();

        previousItem.isAvable = false;
        selectedItems.Remove(previousItem);

        InteractableItem nextItem = OtherItems_Pop();
        selectedItems.Add(nextItem);
        otherItems.Add(previousItem);
        nextItem.isAvable = true;
        
    }
}
