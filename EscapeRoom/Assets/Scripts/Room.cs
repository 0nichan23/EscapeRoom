using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    List<Interacteble> InteractableObjecs = new List<Interacteble>();

    private void Start()
    {
        Interacteble[] objects = GetComponentsInChildren<Interacteble>();
        for (int i = 0; i < objects.Length; i++)
        {
            InteractableObjecs.Add(objects[i]);
        }
        
    }
}
