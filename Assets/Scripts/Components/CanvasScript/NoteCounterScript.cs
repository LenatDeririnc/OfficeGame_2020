using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteCounterScript : MonoBehaviour, IInit
{
    private TMP_Text _text;
    private int count;

    public int Count
    {
        get => count;
        set 
        {
            count = value;
            _text.text = count.ToString() + "/15";
        }
    }

    public void INIT()
    {
        _text = GetComponentInChildren<TMP_Text>();
        Count = 0;
    }

    public void GET()
    {
        
    }

    public void AFTER_INIT()
    {
        
    }
}
