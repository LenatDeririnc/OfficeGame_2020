using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class GachaPanel : MonoBehaviour, IInit
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

    public void INIT()
    {
        onCommandChanged += ChangeCommand;
        currentCoroutine = ShowMessege();
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        gameObject.SetActive(false);
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
