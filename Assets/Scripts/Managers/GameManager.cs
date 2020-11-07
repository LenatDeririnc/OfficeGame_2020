using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ECM.Components;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IInit
{
    private bool isLogicLoaded = false;
    private Scene loadedLevel;

    public static GameManager current;
    public InteractContainer interactContainer;
    public Commands commands;
    [HideInInspector] public PlayerInterface playerInterface;
    [HideInInspector] public MouseLook mouseLook;

    [SerializeField] private GameObject player;

    private List<IInit> INIT_ORDER;

    private void FILL_INIT_ORDER()
    {
        INIT_ORDER = new List<IInit>();
        INIT_ORDER.Add(interactContainer);
        INIT_ORDER.Add(commands);
        INIT_ORDER.Add(playerInterface);
    }
    
    public void INIT()
    {
        current = this;
        playerInterface = player.GetComponent<PlayerInterface>();
        mouseLook = player.GetComponent<MouseLook>();
        BaseInputManager.Init();
        
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

    public void RestartLevel()
    {
        SceneManager.UnloadSceneAsync("Office Logic");
        SceneManager.LoadSceneAsync("Office Logic", LoadSceneMode.Additive);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        SceneManager.LoadSceneAsync("Office Logic", LoadSceneMode.Additive);
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
