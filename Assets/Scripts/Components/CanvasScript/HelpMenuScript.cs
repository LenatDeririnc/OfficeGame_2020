using System.Collections;
using System.Collections.Generic;
using ECM.Components;
using UnityEngine;

public class HelpMenuScript : MonoBehaviour, IInit
{
    private GameObject _gameObject;
    private bool status = false;

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
            
            CanvasScript.current.gameOverTimer.SetPause(status);
            CanvasScript.current.stressLevel.SetPause(status);
            GameManager.current.interactContainer.SetPause(status);
            
            _gameObject.SetActive(status);
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
