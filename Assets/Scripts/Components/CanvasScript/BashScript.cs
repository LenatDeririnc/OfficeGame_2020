using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BashScript : MonoBehaviour, IInit
{
    #region init

    private GameObject _gameObject;
    private TMP_Text text;
    private List<string> commands;

    [SerializeField] [TextArea] private string header;
    [SerializeField] [TextArea] private string botom_header;

    public void INIT()
    {
        commands = new List<string>();
        _gameObject = gameObject;
        text = GetComponentInChildren<TMP_Text>();
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        SetActive(false);
    }

    #endregion

    #region logic

    public void AppendCommand(string command)
    {
        Debug.Log("bashWriting");
        commands.Add(command);
        string returnString = "";
        returnString += header;
        foreach (var item in commands)
        {
            returnString += "\t" + item + "\n";
        }
        returnString += "\t" + botom_header;
        text.text = returnString;
    }

    public void SetActive(bool state)
    {
        _gameObject.SetActive(state);
    }

    #endregion
}
