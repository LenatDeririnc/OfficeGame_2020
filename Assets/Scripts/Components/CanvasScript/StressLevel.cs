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
    [SerializeField] private Image _image;
    [SerializeField] private Gradient gradient;
    private float maxSize;
    private float minValue = .01f;
    private float _currentSize = 1;
    private IEnumerator stressChanger;
    private int _changeValue = 1;
    [SerializeField] private float _changeSpeed = 1;
    private InteractContainer _interactContainer;
    private Dictionary<StationStatus, int> translator;

    public float CurrentSize
    {
        get => _currentSize;
        set
        {
            _currentSize = Mathf.Clamp(value, minValue, 1);
            ChangeSize(_currentSize);
            ChangeColor(_currentSize);

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

    public int ChangeValue
    {
        get => _changeValue;
        set => _changeValue = Mathf.Clamp(value, -100, 1);
    }

    private void INIT_TRANSLATOR()
    {
        translator = new Dictionary<StationStatus, int>();
        translator[StationStatus.Great] = 1;
        translator[StationStatus.Ok] = 0;
        translator[StationStatus.Bad] = -1;
        translator[StationStatus.Died] = -2;
    }

    public void INIT()
    {
        INIT_TRANSLATOR();
        _rect = GetComponent<RectTransform>();
        maxSize = _rect.rect.height;
        CurrentSize = 1;
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
        _image.color = gradient.Evaluate(evaluateValue);
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
