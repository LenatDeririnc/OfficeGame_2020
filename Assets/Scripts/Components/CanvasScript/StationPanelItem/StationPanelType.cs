using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationPanelType : MonoBehaviour, IInit
{
    [SerializeField] private GameObject _computer;
    [SerializeField] private GameObject _printer;
    [SerializeField] private GameObject _server;

    private StationPanelItemType _currentType;

    public StationPanelItemType CurrentType
    {
        get => _currentType;
        set
        {
            _currentType = value;
            ShowType(_currentType);
        }
    }

    private void ShowType(StationPanelItemType type)
    {
        switch (type)
        {
            default:
                _computer.SetActive(false);
                _printer.SetActive(false);
                _server.SetActive(false);
                break;
            case StationPanelItemType.Computer:
                _computer.SetActive(true);
                _printer.SetActive(false);
                _server.SetActive(false);
                break;
            case StationPanelItemType.Printer:
                _computer.SetActive(false);
                _printer.SetActive(true);
                _server.SetActive(false);
                break;
            case StationPanelItemType.Server:
                _computer.SetActive(false);
                _printer.SetActive(false);
                _server.SetActive(true);
                break;
        }
    }

    public void INIT()
    {
        ShowType(_currentType);
        _computer.SetActive(false);
        _printer.SetActive(false);
        _server.SetActive(false);
    }

    public void GET() { }

    public void AFTER_INIT() { }
    
}

public enum StationPanelItemType
{
    Printer,
    Computer,
    Server
}
