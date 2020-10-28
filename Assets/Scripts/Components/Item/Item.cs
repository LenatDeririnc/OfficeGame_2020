using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public override string ToString() => ID();

    public abstract string ID();

    public abstract string InteractName();

    public abstract void Interact();
}
