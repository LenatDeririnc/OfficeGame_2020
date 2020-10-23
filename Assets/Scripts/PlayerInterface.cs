using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

namespace ECM.Controllers
{
    public class PlayerInterface : MonoBehaviour
    {
        protected void InitActions()
        {
            BaseInputManager.Interface.GotoCommandMode.performed += c => SwitchToCommandMode();
            BaseInputManager.CommandMode.ExitFromCommandMode.performed += c => SwitchFromCommandMode();
        }

        public void SwitchToCommandMode()
        {
            BaseInputManager.PlayerMovement.Disable();
            BaseInputManager.Interface.Disable();
            BaseInputManager.CommandMode.Enable();
            // Debug.Log("SwitchedToCommandMode");
            GameEvents.current.CommandModeActivated();
        }

        public void SwitchFromCommandMode()
        {
            BaseInputManager.PlayerMovement.Enable();
            BaseInputManager.Interface.Enable();
            BaseInputManager.CommandMode.Disable();
            // Debug.Log("SwitchedFromCommandMode");
            GameEvents.current.CommandModeExited();
        }

        void Awake()
        {
            InitActions();
        }
    }
}
