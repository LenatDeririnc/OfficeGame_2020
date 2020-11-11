
using System;
using System.Security.Cryptography;
using UnityEngine;

public class NoteItem : Item, IInit
{
    private string m_interactName;
    [SerializeField] private string m_id = "";
    [SerializeField] private InteractableItem objectAccess;
    [HideInInspector] public string command; 

    public override string ID() => m_id;
    public override string InteractName() => m_interactName;

    private GachaPanel _gachaPanel;
    private CommandsPanel _commandsPanel;

    public void INIT()
    {
        m_interactName = "Подобрать";
    }

    public void GET()
    {
        _gachaPanel = CanvasScript.current.gachaPanel;
        _commandsPanel = CanvasScript.current.commandsPanel;
    }

    public void AFTER_INIT()
    {
        command = objectAccess.command;
    }
    
    public override void Interact()
    {
        CanvasScript.current.noteCounterScript.Count += 1;
        NotesScript.current.AddFoundNote(this);
        _gachaPanel.commandName = objectAccess.command;
        _commandsPanel.UpdateCodesCount();
        objectAccess.setAwableForTerminal();
        gameObject.SetActive(false);
    }
}
