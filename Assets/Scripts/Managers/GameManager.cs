using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager current;
    private Scene loadedLevel;
    
    private void Awake()
    {
        current = this;
        BaseInputManager.Init();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Exit()
    {
        Application.Quit();
    }

}
