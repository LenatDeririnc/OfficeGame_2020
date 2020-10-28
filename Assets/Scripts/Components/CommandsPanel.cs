using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CommandsPanel : MonoBehaviour
{
    #region init

    private GameObject _gameObject;
    private TMP_Text text;
    private int itemsCount;

    #endregion

    #region logic

    private void Awake()
    {
        _gameObject = gameObject;
        text = GetComponentInChildren<TMP_Text>();
        itemsCount = 0;
        SetActive(false);
    }

    public void addCommand(string str)
    {
        string returnString = text.text;
        if (itemsCount == 0) returnString += "Команды:\n---------\n";
        returnString += str + "\n";
        text.text = returnString;
        itemsCount++;
    }

    public void SetActive(bool state)
    {
        _gameObject.SetActive(state);
    }

    #endregion


}
