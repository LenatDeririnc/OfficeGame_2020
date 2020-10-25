using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{
    private Transform m_transform;
    private Transform m_camera;
    private Item m_item;
    [SerializeField] private GameObject interactPanel;

    public Item Item
    {
        get => m_item;
        set
        {
            if (m_item != value || (value is null & !(m_item is null)))
            {
                m_item = value;
                if (OnItemChanged != null)
                    OnItemChanged();
            }
        }
    }

    public delegate void OnItemChangedDelegate();
    public event OnItemChangedDelegate OnItemChanged;
    

    private void INIT()
    {
        m_transform = transform;
        m_camera = transform.GetComponentInChildren<Camera>().transform;
    }

    private void INPUTS()
    {
        BaseInputManager.Interface.GotoCommandMode.performed += c => SwitchToCommandMode();
        BaseInputManager.CommandMode.ExitFromCommandMode.performed += c => SwitchFromCommandMode();
        BaseInputManager.Interface.Interact.performed += c => Interact();
    }
    
    private void EVENTS()
    {
        OnItemChanged += ShowInteract;
    }
    
    private void Awake()
    {
        INIT();
        INPUTS();
        EVENTS();
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
    
    private void ShowInteract()
    {
        if (Item is null)
        {
            interactPanel.SetActive(false);
            return;
        }

        interactPanel.SetActive(true);
    }

    private void Interact()
    {
        if (Item is null) return;
        Item.Interact();
    }
    
    RaycastHit raycastHit;

    private void updateRaycast()
    {
        bool hasContact = Physics.Raycast(
            m_camera.position, 
            m_camera.forward, 
            out raycastHit, 
            5f);
        
        Item newItem = null;
        bool gotItem = hasContact ? raycastHit.collider.TryGetComponent(out newItem) : false;
        Item = newItem;
    }
    
    private void Update()
    {
        updateRaycast();
    }
}

