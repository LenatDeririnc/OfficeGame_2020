using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class StationPanelProgress : MonoBehaviour, IInit
{

    [SerializeField] private Image _progress;
    [SerializeField] private Gradient _gradient;
    private float currentFillAmount = 1;

    public float CurrentFillAmount
    {
        get => currentFillAmount;
        set
        {
            float clamp = Mathf.Clamp(value, 0, 1);
            if (Math.Abs(currentFillAmount - clamp) < 0.001f) return;
            currentFillAmount = clamp;
            _progress.fillAmount = currentFillAmount;
            _progress.color = _gradient.Evaluate(currentFillAmount);
        }
    }

    public void INIT()
    {
        
    }

    public void GET()
    {
        
    }

    public void AFTER_INIT()
    {
        
    }
}
