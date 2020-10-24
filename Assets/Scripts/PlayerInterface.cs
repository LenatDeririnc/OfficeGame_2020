using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class PlayerInterface : MonoBehaviour
{
    private void INPUTS()
    {
        BaseInputManager.Interface.GotoCommandMode.performed += c => SwitchToCommandMode();
        BaseInputManager.CommandMode.ExitFromCommandMode.performed += c => SwitchFromCommandMode();
    }
    
    private void Awake()
    {
        INPUTS();
    }

    void SwitchToCommandMode()
    {
        BaseInputManager.PlayerMovement.Disable();
        BaseInputManager.Interface.Disable();
        BaseInputManager.CommandMode.Enable();
        GameEvents.current.CommandModeActivated();
    }

    void SwitchFromCommandMode()
    {
        BaseInputManager.PlayerMovement.Enable();
        BaseInputManager.Interface.Enable();
        BaseInputManager.CommandMode.Disable();
        GameEvents.current.CommandModeExited();
    }
    
}

