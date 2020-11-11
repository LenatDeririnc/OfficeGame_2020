using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesScript : MonoBehaviour, IInit
{

    public static NotesScript current;
    private NoteItem[] notes;
    public List<NoteItem> foundNotes;
    public GameObject[] groups;

    public void AddFoundNote(NoteItem note)
    {
        if (!foundNotes.Contains(note))
        {
            foundNotes.Add(note);
        }
    }
    
    public void INIT()
    {
        current = this;
        notes = GetComponentsInChildren<NoteItem>();
        foundNotes = new List<NoteItem>();
        foreach (var note in notes)
        {
            note.INIT();
        }
    }

    public void GET()
    {
        foreach (var note in notes)
        {
            note.GET();
        }
    }

    public void AFTER_INIT()
    {
        foreach (var note in notes)
        {
            note.AFTER_INIT();
        }
        int randGroup = Random.Range(0, 3);
        for (int i = 0; i < groups.Length; i++)
        {
            if (i != randGroup)
                groups[i].SetActive(false);
        }
    }
}
