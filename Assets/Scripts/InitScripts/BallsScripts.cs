using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsScripts : MonoBehaviour, IInit
{
    public static BallsScripts current;
    private InteractableItem[] balls;

    public InteractableItem[] Balls => balls;

    public void INIT()
    {
        current = this;
        balls = GetComponentsInChildren<InteractableItem>();
        foreach (var ball in balls)
        {
            ball.INIT();
        }
    }

    public void GET()
    {
        foreach (var ball in balls)
        {
            ball.GET();
        }
    }

    public void AFTER_INIT()
    {
        foreach (var ball in balls)
        {
            ball.AFTER_INIT();
        }
    }

    public void StopTimers()
    {
        foreach (var ball in balls)
        {
            ball.StopTimer();
        }
    }

    public void ContinueTimers()
    {
        var currentBalls = GameManager.current.interactContainer.SelectedItems;
        foreach (var ball in currentBalls)
        {
            ball.StartTimer();
        }
    }

}
