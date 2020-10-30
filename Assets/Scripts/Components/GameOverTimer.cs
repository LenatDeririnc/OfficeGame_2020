using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class GameOverTimer : MonoBehaviour
{
    #region init

    private GameObject _gameObject;
    private float timer = 0;
    private TMP_Text currentTMPText;
    private IEnumerator currentTimer;
    private bool isTerminated = false;
    private bool isStarted = false;
    private List<InteractableItem> badSectors;

    private void Awake()
    {
        _gameObject = gameObject;
        badSectors = new List<InteractableItem>();
        currentTMPText = GetComponentInChildren<TMP_Text>();
        currentTimer = timerTick();
        _gameObject.SetActive(false);
    }
    
    #endregion

    #region parameters

    [SerializeField] private string firstMessage = "";
    [SerializeField] private float maxTime = 10;

    #endregion

    #region logic

    public void StartTimer(InteractableItem itemWitchStartsTimer)
    {
        if (!badSectors.Contains(itemWitchStartsTimer)) badSectors.Add(itemWitchStartsTimer);
        if (!isStarted)
        {
            _gameObject.SetActive(true);
            timer = maxTime;
            isTerminated = false;
            StartCoroutine(currentTimer);
            isStarted = true;
        }
    }

    public void StopTimer(InteractableItem itemWhichStopsTimer)
    {
        if (badSectors.Contains(itemWhichStopsTimer)) badSectors.Remove(itemWhichStopsTimer);
        if (isStarted && badSectors.Count == 0)
        {
            _gameObject.SetActive(false);
            isTerminated = true;
            StopCoroutine(currentTimer);
            isStarted = false;
        }
    }

    private IEnumerator timerTick()
    {
        while (!isTerminated)
        {
            Debug.Log("fuck111");
            currentTMPText.text = firstMessage + "\n" + timer + " сек.";
            yield return new WaitForSeconds(1);
            timer = timer - 1;
            if (timer < 0)
            {
                Debug.Log("GAME OVER");
                break;
            }
        }
    }

    #endregion

}
