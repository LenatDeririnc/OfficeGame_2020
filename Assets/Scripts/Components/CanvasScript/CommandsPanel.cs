using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CommandsPanel : MonoBehaviour, IInit
{
    #region init
    
    private GameObject _gameObject;
    private TMP_Text text;
    private List<string> not_used_commands;

    public void INIT()
    {
        not_used_commands = new List<string>();
        _gameObject = gameObject;
        text = GetComponentInChildren<TMP_Text>();
    }

    public void GET()
    {
        
    }

    public void AFTER_INIT()
    {
        SetActive(false);
    }

    #endregion

    #region logic

    public void MoveCommandToBashScript(string note)
    {
        Debug.Log("moved to bash");
        if (!not_used_commands.Contains(note)) return;
        CanvasScript.current.bashScript.AppendCommand(note);
        not_used_commands.Remove(note);
        
    }

    public void UpdateCodesCount(string newNote)
    {
        List<NoteItem> notes = NotesScript.current.foundNotes;
        not_used_commands.Add(newNote);
        Debug.Log("not_used_commands add");
        string returnString = "";
        returnString = "Команды:\n---------\n";
        foreach (var note in not_used_commands)
        {
            returnString += note + "\n";
        }

        text.text = returnString;
    }

    public void SetActive(bool state)
    {
        _gameObject.SetActive(state);
    }

    #endregion


}
