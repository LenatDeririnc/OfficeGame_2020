using System;
using System.Collections;
using System.Collections.Generic;
using ECM.Components;
using UnityEngine;

public class GameOverPanel : MonoBehaviour, IInit
{
    private GameObject _gameObject;
    [SerializeField] private MouseLook _mouseLook;

    public void INIT()
    {
        _gameObject = gameObject;
    }

    public void GET()
    {
        
    }

    public void AFTER_INIT()
    {
        _gameObject.SetActive(false);
    }

    public void Raise()
    {
        BaseInputManager.customCharacterInput.Disable();
        BallsScripts.current.StopTimers();
        _mouseLook.UnlockCursor();
        _gameObject.SetActive(true);
    }
}
