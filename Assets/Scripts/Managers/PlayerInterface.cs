using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour, IInit
{
    public static PlayerInterface current;
    private Transform m_camera;
    private Item m_item;
    public bool _showInteract = true;
    private InputPanelScript inputPanelScript;
    private InteractPanelScript interactPanel;

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

    public bool showInteract
    {
        get => _showInteract;
        set
        {
            _showInteract = value;
            if (!_showInteract) Item = null;
        }
    }

    public delegate void OnItemChangedDelegate();
    public event OnItemChangedDelegate OnItemChanged;


    public void INIT()
    {
        current = this;
        m_camera = transform.GetComponentInChildren<Camera>().transform;
    }

    public void GET()
    {
        interactPanel = CanvasScript.current.interactPanel;
        inputPanelScript = CanvasScript.current.inputPanel;
    }

    public void AFTER_INIT()
    {
        INPUTS();
        EVENTS();
    }

    private void INPUTS()
    {
        BaseInputManager.Interface.GotoCommandMode.performed += c => inputPanelScript.SwitchToCommandMode();;
        BaseInputManager.CommandMode.ExitFromCommandMode.performed += c => inputPanelScript.SwitchFromCommandMode();
        BaseInputManager.Interface.Interact.performed += c => Interact();
    }
    
    private void EVENTS()
    {
        OnItemChanged += ShowInteract;
    }

    private void ShowInteract()
    {
        interactPanel.ShowInteract(Item);
    }

    private void Interact()
    {
        if (Item is null) return;
        Item.Interact();
        Item = null;
    }
    
    RaycastHit raycastHit;

    private void updateRaycast()
    {
        if (_showInteract)
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
    }
    
    private void Update()
    {
        updateRaycast();
    }
}

