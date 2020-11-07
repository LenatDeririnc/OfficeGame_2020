using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InitSequence : MonoBehaviour, IInit
{
    [SerializeField] private CanvasScript _canvasScript;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameEvents _gameEvents;
    [SerializeField] private BallsScripts _ballsScripts;
    [SerializeField] private NotesScript _notesScript;
    [SerializeField] private InteractItems _interactItems;

    private List<IInit> INIT_ORDER;

    private void FILL_INIT_ORDER()
    {
        INIT_ORDER = new List<IInit>();
        INIT_ORDER.Add(_ballsScripts);
        INIT_ORDER.Add(_notesScript);
        INIT_ORDER.Add(_interactItems);
        INIT_ORDER.Add(_gameManager);
        INIT_ORDER.Add(_canvasScript);
        INIT_ORDER.Add(_gameEvents);
    }
    
    public void INIT()
    {
        FILL_INIT_ORDER();
        foreach (var initElement in INIT_ORDER)
        {
            initElement.INIT();
        }
    }

    public void GET()
    {
        foreach (var initElement in INIT_ORDER)
        {
            initElement.GET();
        }
    }

    public void AFTER_INIT()
    {
        foreach (var initElement in INIT_ORDER)
        {
            initElement.AFTER_INIT();
        }
    }

    private void Awake()
    {
        INIT();
        GET();
        AFTER_INIT();
    }
}
