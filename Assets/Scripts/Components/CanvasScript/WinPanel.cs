using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class WinPanel : MonoBehaviour, IInit
{
    private GameObject _gameObject;
    private InteractableItem[] _items;
    private GameOverPanel _gameOver;
    private List<InteractableItem> _goodSectors;

    public void INIT()
    {
        _gameObject = gameObject;
        _goodSectors = new List<InteractableItem>();
    }

    public void GET()
    {
        _gameOver = GetComponent<GameOverPanel>();
        //TODO: заменить
        _items = FindObjectsOfType<InteractableItem>();
    }

    public void AFTER_INIT()
    {
        _gameObject.SetActive(false);
    }

    public void AppendGoodSector(InteractableItem item)
    {
        // if (_goodSectors.Contains(item)) return;
        // _goodSectors.Add(item);
        // if ((_goodSectors.Count) == _items.Length)
        // {
        //     foreach (InteractableItem currentItem in _items)
        //     {
        //         currentItem.StopTimer();
        //     }
        //     _gameOver.Raise();
        // }
    }
    
    public void RemoveGoodSector(InteractableItem item)
    {
        if (_goodSectors.Contains(item)) _goodSectors.Remove(item);
    }
}
