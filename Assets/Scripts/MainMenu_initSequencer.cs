using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_initSequencer : MonoBehaviour, IInit
{
    public static MainMenu_initSequencer current;
    [SerializeField] private GameManager _gameManager;

    private List<IInit> INIT_ORDER;

    private void FILL_INIT_ORDER()
    {
        INIT_ORDER = new List<IInit>();
        INIT_ORDER.Add(_gameManager);
    }
    
    public void INIT()
    {
        current = this;
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
        START_INIT();
    }

    public void START_INIT()
    {
        INIT();
        GET();
        AFTER_INIT();
    }
}
