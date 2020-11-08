using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadSectorsScript : MonoBehaviour, IInit
{
    private Dictionary<InteractableItem, StationStatus> sectors;
    private Dictionary<StationStatus, int> translator;
    private BallsScripts balls;

    public void INIT()
    {
        sectors = new Dictionary<InteractableItem, StationStatus>();
    }

    public void GET()
    {
        balls = BallsScripts.current;
    }

    public void AFTER_INIT()
    {
        
    }

    void ChangeStatus(InteractableItem item, StationStatus status)
    {
        sectors[item] = status;
    }

}
