using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Configuration;
using TMPro;
using UnityEngine;

public class GachaPanel : MonoBehaviour
{
    private IEnumerator currentCoroutine;
    [SerializeField] private TMP_Text commandLabel;
    private string _commandName;
    [SerializeField] private float maxTime;

    public string commandName
    {
        get => _commandName;
        set
        {
            if (_commandName == value) return;
            _commandName = value;
            onCommandChanged();
        }
    }

    private event Action onCommandChanged;

    private void Awake()
    {
        onCommandChanged += ChangeCommand;
        gameObject.SetActive(false);
        currentCoroutine = ShowMessege();
    }
    
    void ChangeCommand()
    {
        terminated = true;
        StopCoroutine(currentCoroutine);
        currentCoroutine = ShowMessege();
        commandLabel.text = commandName;
        gameObject.SetActive(true);
        StartCoroutine(currentCoroutine);
        terminated = false;
    }

    private bool terminated = false;
    IEnumerator ShowMessege()
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(maxTime);
        if (!terminated) gameObject.SetActive(false);
    }
}
