using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static List<Interacteble> inventory = new List<Interacteble>();

    public void Interact(Interacteble interactable)
    {
        if (inventory.Contains(interactable.NeededItem))
        {
            interactable.Activate();
        }
    }
}
