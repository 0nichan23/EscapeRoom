using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    public List<Interacteble> inventory;


    private void Start()
    {
        inventory = new List<Interacteble>();
    }
    public void Interact(Interacteble interactable)
    {
        if (inventory.Contains(interactable.NeededItem))
        {
            interactable.Interact();
        }
    }

    public void Additem(Interacteble item)
    {
        inventory.Add(item);
    }

}
