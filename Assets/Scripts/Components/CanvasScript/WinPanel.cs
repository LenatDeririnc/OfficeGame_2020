using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ECM.Components;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class WinPanel : MonoBehaviour, IInit
{
    private GameObject _gameObject;
    private GameOverPanel _gameOver;

    public void INIT()
    {
        _gameOver = GetComponent<GameOverPanel>();
        _gameOver.INIT();
        _gameObject = gameObject;
    }

    public void GET()
    {
        _gameOver.GET();
    }

    public void AFTER_INIT()
    {
        _gameObject.SetActive(false);
    }

    public void Raise()
    {
        _gameOver.Raise();
    }
}
