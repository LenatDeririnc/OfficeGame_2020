using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager current;
    private bool isLogicLoaded = false;
    public InteractContainer interactContainer;
    private Scene loadedLevel;
    
    private void Awake()
    {
        current = this;
        BaseInputManager.Init();
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
