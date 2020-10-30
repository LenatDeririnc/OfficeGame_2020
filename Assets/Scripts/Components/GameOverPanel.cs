using System;
using System.Collections;
using System.Collections.Generic;
using ECM.Components;
using UnityEngine;

public class GameOverPanel : MonoBehaviour, IInit
{
    private GameObject _gameObject;
    [SerializeField] private MouseLook _mouseLook;

    private void Awake()
    {
        INIT();
    }

    public void Raise()
    {
        BaseInputManager.customCharacterInput.Disable();
        StopAllCoroutines();
        _mouseLook.UnlockCursor();
        _gameObject.SetActive(true);
    }

    public void INIT()
    {
        _gameObject = gameObject;
        _gameObject.SetActive(false);
    }
}
