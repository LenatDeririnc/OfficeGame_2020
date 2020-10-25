using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractPanelScript : MonoBehaviour
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

    private void ChangeCaptureName()
    {
        text.text = "{\"F\": \"" + CaptureName + "\"}";
    }

    public void SetActive(bool state)
    {
        gameObject.SetActive(state);
    }

    private void Awake()
    {
        text = GetComponentInChildren<TMP_Text>();
        OnCaptureChanged += ChangeCaptureName;
        ChangeCaptureName();
        SetActive(false);
    }
}
