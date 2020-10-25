
using System.Security.Cryptography;
using UnityEngine;

public class NoteItem : Item
{
    [SerializeField] private string m_id = "";
    private string m_interactName = "Подобрать";
    public override string ID() => m_id;
    public override string interactName() => m_interactName;

    public override void Interact()
    {
        Destroy(gameObject);
        Debug.Log("Ты получил код для терминала!");
    }
}
