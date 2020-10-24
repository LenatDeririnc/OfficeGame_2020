using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ID = "sword";

    public void Take()
    {
        Destroy(gameObject);
    }
}
