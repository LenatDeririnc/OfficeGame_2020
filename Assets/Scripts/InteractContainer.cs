using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class InteractContainer : MonoBehaviour, IInit
{
    [SerializeField] private float appendItemIntervalSeconds;
    [SerializeField] private int startActiveElements;
    [SerializeField] private int maxActiveElements;
    private InteractableItem[] items;
    private List<InteractableItem> selectedItems;
    private List<InteractableItem> otherItems;

    public List<InteractableItem> SelectedItems => selectedItems;
    public List<InteractableItem> OtherItems => otherItems;

    public void INIT()
    {
        selectedItems = new List<InteractableItem>();
        otherItems = new List<InteractableItem>();
        AppendItemCountCorutine = AppendItemCount();
    }

    public void GET()
    {
        items = BallsScripts.current.Balls;
    }

    public void AFTER_INIT()
    {
        RefreshItemsOrder();
        SelectItems();
        StartCoroutine(AppendItemCountCorutine);
    }

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
            if (i < startActiveElements)
            {
                selectedItems.Add(items[i]);
                items[i].isAvable = true;
            }
            else
            {
                items[i].health = items[i].maxHealth;
                items[i].OnStationStatusChanged();
                otherItems.Add(items[i]);
            }
        }
    }

    public void SetPause(bool state)
    {
        if (state)
        {
            StopCoroutine(AppendItemCountCorutine);
        }
        else
        {
            StartCoroutine(AppendItemCountCorutine);
        }
    }

    private IEnumerator AppendItemCountCorutine;
    IEnumerator AppendItemCount()
    {
        yield return new WaitForSeconds(appendItemIntervalSeconds);
        if (selectedItems.Count < maxActiveElements)
        {
            var newItem = OtherItems_Pop();
            selectedItems.Add(newItem);
            newItem.isAvable = true;
            // CanvasScript.current.stationsPanel.updateItems();
        }
    }

    public void Next(InteractableItem previousItem)
    {
        InteractableItem nextItem;
        nextItem = OtherItems_Pop();
        
        previousItem.isAvable = false;
        selectedItems.Remove(previousItem);
        selectedItems.Add(nextItem);
        otherItems.Add(previousItem);
        nextItem.isAvable = true;

        // CanvasScript.current.stationsPanel.updateItems();
    }
}
