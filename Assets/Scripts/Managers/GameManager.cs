using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

public class GameManager : MonoBehaviour
{
    public static GameManager current;
    public Commands commands;
    public InteractPanelScript interactPanelScript;
    private void Awake()
    {
        BaseInputManager.Init();
        commands = GetComponent<Commands>();
        current = this;
    }

}
