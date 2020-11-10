using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class StationPanelItem : MonoBehaviour, IInit
{
    private IInit[] CLASSES_TO_INIT;
    private GameObject _gameObject;
    
    [SerializeField] private StationPanelProgress _progressClass;
    [SerializeField] private StationPanelNumber _numberClass;
    [SerializeField] private StationPanelType _typeClass;

    // служат для отображения информации в инспекторе
    [SerializeField] private float progress;
    [SerializeField] private int number;
    [SerializeField] private StationPanelItemType type;

    public float Progress
    {
        get => _progressClass.CurrentFillAmount;
        set
        {
            float newValue = Mathf.Clamp(value, 0, 1);
            if (Math.Abs(progress - newValue) < 0.001f) return;
            progress = newValue;
            _progressClass.CurrentFillAmount = progress;
        }
    }

    public int Number
    {
        get => _numberClass.CurrentNumber;
        set
        {
            int newValue = Mathf.Clamp(value, 1, 9);
            number = newValue;
            _numberClass.CurrentNumber = number;
        }
    }

    public StationPanelItemType Type
    {
        get => _typeClass.CurrentType;
        set
        {
            type = value;
            _typeClass.CurrentType = type;
        }
    }

    private void INIT_CLASSES()
    {
        CLASSES_TO_INIT = new IInit[]
        {
            _progressClass,
            _numberClass,
            _typeClass
        };
    }

    public void ConvertToProgressValue(float value, float minValue, float maxValue)
    {
        var midValue = maxValue - minValue;
        Progress = value / midValue;
    }

    public void ShowObject()
    {
        _gameObject.SetActive(true);
        _typeClass.CurrentType = type;
        _numberClass.CurrentNumber = number;
    }

    public void HideObject()
    {
        _gameObject.SetActive(false);
        _typeClass.CurrentType = type;
        _numberClass.CurrentNumber = number;
    }

    public void UpdatePictures()
    {
        _typeClass.CurrentType = type;
        _numberClass.CurrentNumber = number;
    }
    
    public void INIT()
    {
        _gameObject = gameObject;
        INIT_CLASSES();
        foreach (var class_to_init in CLASSES_TO_INIT)
        {
            class_to_init.INIT();
        }

        UpdatePictures();
    }

    public void GET()
    {
        foreach (var class_to_init in CLASSES_TO_INIT)
        {
            class_to_init.GET();
        }
    }

    public void AFTER_INIT()
    {
        
        foreach (var class_to_init in CLASSES_TO_INIT)
        {
            class_to_init.AFTER_INIT();
        }
    }
}