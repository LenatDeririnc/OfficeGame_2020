
using System;
using System.Security.Cryptography;
using UnityEngine;

public class NoteItem : Item
{
    [SerializeField] private string m_id = "";
    private string m_interactName = "Подобрать";
    [SerializeField] private InteractableItem objectAccess;

    public override string ID() => m_id;
    public override string InteractName() => m_interactName;

    public override void Interact()
    {
        CanvasScript.current.gachaPanel.commandName = objectAccess.command;
        CanvasScript.current.commandsPanel.addCommand(objectAccess.command);
        objectAccess.setAwableForTerminal();
        gameObject.SetActive(false);
    }
}
