using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public static class BaseInputManager
{
    public static CustomCharacterInput customCharacterInput;
    public static CustomCharacterInput.PlayerMovementActions PlayerMovement;
    public static CustomCharacterInput.CommandModeActions CommandMode;
    public static CustomCharacterInput.InterfaceActions Interface;
    public static CustomCharacterInput.DevelopActions Develop;

    public static void Init()
    {
        customCharacterInput = new CustomCharacterInput();
        PlayerMovement = customCharacterInput.PlayerMovement;
        CommandMode = customCharacterInput.CommandMode;
        Interface = customCharacterInput.Interface;
        Develop = customCharacterInput.Develop;

        PlayerMovement.Enable();
        Interface.Enable();
    }

}

