using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public override string ToString() => ID();

    public abstract string ID();

    public abstract string interactName();

    public abstract void Interact();
}
