using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsScript : MonoBehaviour
{
    [SerializeField] private InteractableItem[] balls;
    private void Awake()
    {
        balls = GetComponentsInChildren<InteractableItem>();
    }
    
    
}
