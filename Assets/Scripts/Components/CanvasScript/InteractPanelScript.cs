using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractPanelScript : MonoBehaviour, IInit
{
    private TMP_Text text;
    private string m_captureName = "";

    public string CaptureName
    {
        get => m_captureName;
        set
        {
            if (m_captureName == value) return;
            m_captureName = value;
            if (OnCaptureChanged != null)
                OnCaptureChanged();
        }
    }
    
    private event Action OnCaptureChanged;

    public void INIT()
    {
        OnCaptureChanged += ChangeCaptureName;
        text = GetComponentInChildren<TMP_Text>();
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        SetActive(false);
    }

    private void ChangeCaptureName()
    {
        text.text = "{\"F\": \"" + CaptureName + "\"}";
    }

    public void SetActive(bool state)
    {
        gameObject.SetActive(state);
    }

    public void ShowInteract(Item item)
    {
        if (item is null)
        {
            SetActive(false);
            return;
        }

        CaptureName = item.InteractName();
        SetActive(true);
    }
}
