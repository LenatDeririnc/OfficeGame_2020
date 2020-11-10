using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ECM.Components;
using ECM.Controllers;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IInit
{
    private bool isLogicLoaded = false;
    private Scene loadedLevel;

    public static GameManager current;
    public InteractContainer interactContainer;
    public Commands commands;
    [HideInInspector] public PlayerInterface playerInterface;
    [HideInInspector] public MouseLook mouseLook;
    [HideInInspector] public BaseCharacterController baseCharacterController;
    [HideInInspector] public BaseFirstPersonController baseFirstPersonController;

    [SerializeField] private GameObject player;

    private List<IInit> INIT_ORDER;

    private static Action<InputAction.CallbackContext> ViewHorizontal;
    private static Action<InputAction.CallbackContext> ViewVertical;
    private static Action<InputAction.CallbackContext> Horizontal;
    private static Action<InputAction.CallbackContext> Vertical;
    private static Action<InputAction.CallbackContext> Run;
    private static Action<InputAction.CallbackContext> Pause;
    private static Action<InputAction.CallbackContext> StopMoving;
    private static Action<InputAction.CallbackContext> Interact;
    private static Action<InputAction.CallbackContext> StopInteract;
    private static Action<InputAction.CallbackContext> ExitFromConsole;

    private void FILL_INIT_ORDER()
    {
        INIT_ORDER = new List<IInit>();
        INIT_ORDER.Add(interactContainer);
        INIT_ORDER.Add(commands);
        INIT_ORDER.Add(playerInterface);
    }

    public void FILL_INPUT_DELIGATES()
    {
        ViewHorizontal = context => mouseLook.HorizontalVelocity(context);
        ViewVertical = context => mouseLook.VerticalVelocity(context);
        Horizontal = context => baseCharacterController.MoveHorizontal(context);
        Vertical = context => baseCharacterController.MoveVertical(context);
        Run = context => baseFirstPersonController.Run(context);
        Pause = context => CanvasScript.current.pauseScript.Raise();
        StopMoving = context => baseCharacterController.SetPause(context); 
        Interact = context => playerInterface.Interact();
        StopInteract = context => CanvasScript.current.interactProgressBar.StopProgress();
        ExitFromConsole = context => CanvasScript.current.inputPanel.SwitchFromCommandMode();
    }

    public void SubscribeInput()
    {
        BaseInputManager.PlayerMovement.ViewHorizontal.performed += ViewHorizontal;
        BaseInputManager.PlayerMovement.ViewHorizontal.canceled += ViewHorizontal;
        BaseInputManager.PlayerMovement.ViewVertical.performed += ViewVertical;
        BaseInputManager.PlayerMovement.ViewVertical.canceled += ViewVertical;
        
        BaseInputManager.PlayerMovement.Horizontal.performed += Horizontal;
        BaseInputManager.PlayerMovement.Horizontal.canceled += Horizontal;
        BaseInputManager.PlayerMovement.Vertical.performed += Vertical;
        BaseInputManager.PlayerMovement.Vertical.canceled += Vertical;
        BaseInputManager.PlayerMovement.Run.started += Run;
        BaseInputManager.PlayerMovement.Run.canceled += Run;
        
        BaseInputManager.Interface.Pause.performed += Pause;
        BaseInputManager.Interface.Pause.performed += StopMoving;
        BaseInputManager.Interface.Interact.performed += Interact;
        BaseInputManager.CommandMode.ExitFromCommandMode.performed += ExitFromConsole;
    }

    public void UnsubscribeInput()
    {
        BaseInputManager.PlayerMovement.ViewHorizontal.performed -= ViewHorizontal;
        BaseInputManager.PlayerMovement.ViewHorizontal.canceled -= ViewHorizontal;
        BaseInputManager.PlayerMovement.ViewVertical.performed -= ViewVertical;
        BaseInputManager.PlayerMovement.ViewVertical.canceled -= ViewVertical;
        
        BaseInputManager.PlayerMovement.Horizontal.performed -= Horizontal;
        BaseInputManager.PlayerMovement.Horizontal.canceled -= Horizontal;
        BaseInputManager.PlayerMovement.Vertical.performed -= Vertical;
        BaseInputManager.PlayerMovement.Vertical.canceled -= Vertical;
        BaseInputManager.PlayerMovement.Run.started -= Run;
        BaseInputManager.PlayerMovement.Run.canceled -= Run;
        
        BaseInputManager.Interface.Pause.performed -= Pause;
        BaseInputManager.Interface.Pause.performed -= StopMoving;
        BaseInputManager.Interface.Interact.performed -= Interact;
        BaseInputManager.Interface.Interact.canceled -= StopInteract;
        BaseInputManager.CommandMode.ExitFromCommandMode.performed -= ExitFromConsole;
    }
    
    public void INIT()
    {
        current = this;
        if (player != null)
        {
            playerInterface = player.GetComponent<PlayerInterface>();
            mouseLook = player.GetComponent<MouseLook>();
            baseCharacterController = player.GetComponent<BaseCharacterController>();
            baseFirstPersonController = player.GetComponent<BaseFirstPersonController>();
        }

        BaseInputManager.Init();
        
        FILL_INIT_ORDER();

        foreach (var initElement in INIT_ORDER)
        {
            if (initElement != null)
                initElement.INIT();
        }
    }

    public void GET()
    {
        foreach (var initElement in INIT_ORDER)
        {
            if (initElement != null)
                initElement.GET();
        }
    }

    public void AFTER_INIT()
    {
        foreach (var initElement in INIT_ORDER)
        {
            if (initElement != null)
                initElement.AFTER_INIT();
        }
    }

    public void RestartLevel()
    {
        UnsubscribeInput();
        SceneManager.UnloadSceneAsync("Office Logic 1");
        SceneManager.LoadSceneAsync("Office Logic 1", LoadSceneMode.Additive);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        SceneManager.LoadSceneAsync("Office Logic 1", LoadSceneMode.Additive);
    }

    public void GotoMainMenu()
    {
        UnsubscribeInput();
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
