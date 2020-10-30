using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class WinPanel : MonoBehaviour, IInit
{
    private InteractableItem[] _items;
    private GameOverPanel _gameOver;
    private List<InteractableItem> _goodSectors;

    private void Awake()
    {
        INIT();
    }
    
    public void INIT()
    {
        _gameOver = GetComponent<GameOverPanel>();
        _items = FindObjectsOfType<InteractableItem>();
        _goodSectors = new List<InteractableItem>();
    }

    public void AppendGoodSector(InteractableItem item)
    {
        if (_goodSectors.Contains(item)) return;
        _goodSectors.Add(item);
        if ((_goodSectors.Count) == _items.Length)
        {
            foreach (InteractableItem currentItem in _items)
            {
                currentItem.StopTimer();
            }
            _gameOver.Raise();
        }
    }
    
    public void RemoveGoodSector(InteractableItem item)
    {
        if (_goodSectors.Contains(item)) _goodSectors.Remove(item);
    }
}
