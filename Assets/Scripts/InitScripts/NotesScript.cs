using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesScript : MonoBehaviour, IInit
{

    public static NotesScript current;
    private NoteItem[] notes;
    public List<NoteItem> foundNotes;

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
    }
}
