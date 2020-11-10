using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationPanelNumber : MonoBehaviour, IInit
{
    [SerializeField] private GameObject _one;
    [SerializeField] private GameObject _two;
    [SerializeField] private GameObject _three;
    [SerializeField] private GameObject _four;
    [SerializeField] private GameObject _five;
    [SerializeField] private GameObject _six;
    [SerializeField] private GameObject _seven;
    [SerializeField] private GameObject _eight;
    [SerializeField] private GameObject _nine;

    private GameObject[] _imagesArray;

    private int _currentNumber;

    public int CurrentNumber
    {
        get => _currentNumber;
        set
        {
            int newValue = Mathf.Clamp(value, 1, 9);
            if (_currentNumber == newValue) return;
            _currentNumber = newValue;
            
            ShowNumber(_currentNumber - 1);
        }
    }

    void INIT_LIST()
    {
        _imagesArray = new GameObject[]
        {
            _one,
            _two,
            _three,
            _four,
            _five,
            _six,
            _seven,
            _eight,
            _nine
        };
    }

    private void ShowNumber(int number)
    {
        for (int i = 0; i < _imagesArray.Length; i++)
        {
            if (i == number)
                _imagesArray[i].SetActive(true);
            else 
                _imagesArray[i].SetActive(false);
        }
    }

    public void INIT()
    {
        INIT_LIST();
    }

    public void GET()
    {
        
    }

    public void AFTER_INIT()
    {
        
    }
}
