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
    [SerializeField] private float greenZonesValue;
    [SerializeField] private float yellowZonesValue;
    [SerializeField] private float redZonesValue;
    [SerializeField] private float blackZonesValue;
    [Space] 
    [SerializeField] private float greenZoneRepairValue;
    [SerializeField] private float yellowZoneRepairValue;
    [SerializeField] private float redZoneRepairValue;
    [SerializeField] private float blackZoneRepairValue;
    [SerializeField] private float terminalRepairValue;
    [Space]
    [SerializeField] private float _changeSpeed = 1;
    private RectTransform _rect;
    private float goodSector = 2f / 3f;
    private float okSector = 1f / 3f;
    private float maxSize;
    private float minValue = .01f;
    private float _currentSize = 1;
    private IEnumerator stressChanger;
    private float _changeValue = 1;
    private InteractContainer _interactContainer;
    private int currentFace;
    private List<InteractableItem> yellowList;
    private List<InteractableItem> redList;
    private List<InteractableItem> blackList;

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

    public void AddToYellowList(InteractableItem item)
    {
        if (!yellowList.Contains(item))
            yellowList.Add(item);
    }

    public void AddToRedList(InteractableItem item)
    {
        if (!redList.Contains(item))
            redList.Add(item);
    }
    
    public void AddToBlackList(InteractableItem item)
    {
        if (!blackList.Contains(item))
            redList.Add(item);
    }

    public void RemoveFromAllLists(InteractableItem item)
    {
        if (yellowList.Contains(item))
            yellowList.Remove(item);
        if (redList.Contains(item))
            redList.Remove(item);
        if (blackList.Contains(item))
            blackList.Remove(item);
    }
    
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

            if (Math.Abs(_currentSize - minValue) < 0.00001)
            {
                CanvasScript.current.gameOverTimer.StartTimer();
            }
            else
            {
                CanvasScript.current.gameOverTimer.StopTimer();

                if (Math.Abs(_currentSize - 1) < 0.00001)
                {
                    CanvasScript.current.winPanel.Raise();
                }
            }
        }
    }

    public float ChangeValue
    {
        get => _changeValue;
        set
        {
            if (Math.Abs(value - _changeValue) < 0.0001f) return;
            _changeValue = Mathf.Clamp(value, -100, 1);
            
            
        }
    }

    private void INIT_LISTS()
    {
        yellowList = new List<InteractableItem>();
        redList = new List<InteractableItem>();
        blackList = new List<InteractableItem>();
    }

    public void INIT()
    {
        INIT_LISTS();
        _rect = GetComponent<RectTransform>();
        maxSize = _rect.rect.height;
        CurrentSize = startValue;
    }

    public void GET()
    {
        _interactContainer = GameManager.current.interactContainer;
    }

    private IEnumerator updateCorutine;
    public void AFTER_INIT()
    {
        updateCorutine = UpdateCorutine();
        StartCoroutine(updateCorutine);
    }

    public void SetPause(bool state)
    {
        if (!state)
        {
            StartCoroutine(updateCorutine);
        }
        else
        {
            StopCoroutine(updateCorutine);
        }
    }

    private float CalculateHeight(float percent)
    {
        var newValue = Mathf.Clamp(percent, 0, 1);
        return newValue * maxSize;
    }

    private void CheckListsForMinimumValue()
    {
        if (blackList.Count > 0)
        {
            ChangeValue = blackZonesValue;
            return;
        }
        
        if (redList.Count > 0)
        {
            ChangeValue = redZonesValue;
            return;
        }

        if (yellowList.Count > 0)
        {
            ChangeValue = yellowZonesValue;
            return;
        }

        ChangeValue = greenZonesValue;
    }

    public void PowerUpLevel(StationStatus status, bool fixedWithTerminal)
    {
        if (fixedWithTerminal)
        {
            CurrentSize += terminalRepairValue;
            return;
        }

        switch (status)
        {
            default:
                CurrentSize += greenZoneRepairValue;
                break;
            case StationStatus.Ok:
                CurrentSize += yellowZoneRepairValue;
                break;
            case StationStatus.Bad:
                CurrentSize += redZoneRepairValue;
                break;
            case StationStatus.Died:
                CurrentSize += blackZoneRepairValue;
                break;
        }

    }

    public void CheckCurrentBalls(InteractableItem item)
    {
        StationStatus status = item.CurrentStatus;
        switch (status)
        {
            default:
                RemoveFromAllLists(item);
                CheckListsForMinimumValue();
                break;
            case StationStatus.Ok:
                RemoveFromAllLists(item);
                AddToYellowList(item);
                CheckListsForMinimumValue();
                break;
            case StationStatus.Bad:
                RemoveFromAllLists(item);
                AddToRedList(item);
                CheckListsForMinimumValue();
                break;
            case StationStatus.Died:
                RemoveFromAllLists(item);
                AddToBlackList(item);
                CheckListsForMinimumValue();
                break;
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
