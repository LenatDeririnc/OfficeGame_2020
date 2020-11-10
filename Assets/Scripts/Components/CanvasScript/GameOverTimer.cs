using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class GameOverTimer : MonoBehaviour, IInit
{
    #region init

    private GameObject _gameObject;
    private float timer = 0;
    private TMP_Text currentTMPText;
    private IEnumerator currentTimer;
    private bool isTerminated = false;
    private bool isStarted = false;

    public void INIT()
    {
        _gameObject = gameObject;
        currentTimer = timerTick();
        currentTMPText = GetComponentInChildren<TMP_Text>();
    }

    public void GET()
    {
        // throw new NotImplementedException();
    }

    public void AFTER_INIT()
    {
        _gameObject.SetActive(false);
    }

    #endregion

    #region parameters

    [SerializeField] private string firstMessage = "";
    [SerializeField] private float maxTime = 10;

    #endregion

    #region logic

    public void StartTimer()
    {
        if (!isStarted)
        {
            _gameObject.SetActive(true);
            timer = maxTime;
            isTerminated = false;
            StartCoroutine(currentTimer);
            isStarted = true;
        }
    }

    public void StopTimer()
    {
        if (isStarted)
        {
            _gameObject.SetActive(false);
            isTerminated = true;
            StopCoroutine(currentTimer);
            isStarted = false;
        }
    }

    public void SetPause(bool state)
    {
        if (isStarted)
        {
            if (state)
            {
                StopCoroutine(currentTimer);
            }
            else
            {
                StartCoroutine(currentTimer);
            }
        }
    }

    private IEnumerator timerTick()
    {
        while (!isTerminated)
        {
            currentTMPText.text = firstMessage + "\n" + timer + " сек.";
            yield return new WaitForSeconds(1);
            timer = timer - 1;
            if (timer < 0)
            {
                CanvasScript.current.gameOverPanel.Raise();
                break;
            }
        }
    }

    #endregion

}
