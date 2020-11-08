using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class StressLevel : MonoBehaviour, IInit
{
    private RectTransform _rect;
    [SerializeField] private Image _line;
    [SerializeField] private Image _foregroundCircle;
    [SerializeField] private GameObject _greatSmile;
    [SerializeField] private GameObject _okSmile;
    [SerializeField] private GameObject _badSmile;
    [Space]
    [SerializeField] private Gradient gradient;
    [Space]
    [SerializeField] private float startValue = .6f;
    [Space]
    [SerializeField] private float greatZonesValue;
    [SerializeField] private float okZonesValue;
    [SerializeField] private float badZonesValue;
    [SerializeField] private float diedZonesValue;
    [Space]
    [SerializeField] private float _changeSpeed = 1;
    private float maxSize;
    private float minValue = .01f;
    private float _currentSize = 1;
    private IEnumerator stressChanger;
    private float _changeValue = 1;
    private InteractContainer _interactContainer;
    private Dictionary<StationStatus, float> translator;
    private int currentFace;

    private int CurrentFace
    {
        get => currentFace;
        set
        {
            if (value == currentFace) return;
            currentFace = value;
            _greatSmile.SetActive(currentFace == 1);
            _okSmile.SetActive(currentFace == 2);
            _badSmile.SetActive(currentFace == 3);
        }
    }

    private float goodSector = 2f / 3f;
    private float okSector = 1f / 3f;
    private void ChangeSmileFace(float size)
    {
        switch (size)
        {
            default:
                CurrentFace = 1;
                break;
            case float s when (s <= goodSector && s > okSector):
                CurrentFace = 2;
                break;
            case float s when (s <= okSector):
                CurrentFace = 3;
                break;
        }
    }

    public float CurrentSize
    {
        get => _currentSize;
        set
        {
            _currentSize = Mathf.Clamp(value, minValue, 1);
            ChangeSize(_currentSize);
            ChangeColor(_currentSize);
            ChangeSmileFace(_currentSize);

            if (Math.Abs(_currentSize - minValue) < 0.001)
            {
                CanvasScript.current.gameOverTimer.StartTimer();
            }
            else
            {
                CanvasScript.current.gameOverTimer.StopTimer();
            }
        }
    }

    public float ChangeValue
    {
        get => _changeValue;
        set => _changeValue = Mathf.Clamp(value, -100, 1);
    }

    private void INIT_TRANSLATOR()
    {
        translator = new Dictionary<StationStatus, float>();
        translator[StationStatus.Great] = greatZonesValue;
        translator[StationStatus.Ok] = okZonesValue;
        translator[StationStatus.Bad] = badZonesValue;
        translator[StationStatus.Died] = diedZonesValue;
    }

    public void INIT()
    {
        INIT_TRANSLATOR();
        _rect = GetComponent<RectTransform>();
        maxSize = _rect.rect.height;
        CurrentSize = startValue;
    }

    public void GET()
    {
        _interactContainer = GameManager.current.interactContainer;
    }

    public void AFTER_INIT()
    {
        StartCoroutine(UpdateCorutine());
    }

    private float CalculateHeight(float percent)
    {
        var newValue = Mathf.Clamp(percent, 0, 1);
        return newValue * maxSize;
    }

    public void CheckCurrentBalls()
    {
        ChangeValue = 0;
        List<InteractableItem> selectedItems = _interactContainer.SelectedItems;
        foreach (InteractableItem item in selectedItems)
        {
            ChangeValue += translator[item.CurrentStatus];
        }
    }

    private void ChangeSize(float value)
    {
        _rect.sizeDelta = new Vector2(_rect.sizeDelta.x,CalculateHeight(value)); 
    }

    private void ChangeColor(float evaluateValue)
    {
        _line.color = gradient.Evaluate(evaluateValue);
        _foregroundCircle.color = gradient.Evaluate(evaluateValue);
    }

    private IEnumerator UpdateCorutine()
    {
        while (true)
        {
            CurrentSize += Time.deltaTime * _changeValue * _changeSpeed;
            yield return null;   
        }
    }
}
