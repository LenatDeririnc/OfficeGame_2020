using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CommandsPanel : MonoBehaviour, IInit
{
    #region init

    private GameObject _gameObject;
    private TMP_Text text;
    private int itemsCount;

    public void INIT()
    {
        _gameObject = gameObject;
        text = GetComponentInChildren<TMP_Text>();
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        itemsCount = 0;
        SetActive(false);
    }

    #endregion

    #region logic

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
