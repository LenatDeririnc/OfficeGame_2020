using System.Collections;
using System.Collections.Generic;
using ECM.Components;
using UnityEngine;

public class PauseScript : MonoBehaviour, IInit
{

    private GameObject _gameObject;
    private bool status = false;
    [SerializeField] private MouseLook _mouseLook;

    public bool Status
    {
        get => status;
        set
        {
            if (status == value) return;
            status = value;

            if (status)
            {
                BallsScripts.current.StopTimers();
            }
            else
            {
                BallsScripts.current.ContinueTimers();
            }
            _gameObject.SetActive(status);
            _mouseLook.SetCursorLock(!status);
        }
    }

    public void INIT()
    {
        _gameObject = gameObject;
        _gameObject.SetActive(false);
    }

    public void Raise()
    {
        Status = !Status;
    }

    public void GET()
    {
        
    }

    public void AFTER_INIT()
    {
        
    }
}
