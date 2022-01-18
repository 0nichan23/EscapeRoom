using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : Interacteble
{
    public Interacteble itemInside;
    public override void Activate()
    {
        Open();
    }

    void Open()
    {
        if (itemInside != null)
        {
            itemInside.gameObject.SetActive(true);
            Debug.Log("spawm");
           
        }
        else
        {
            Debug.Log("nothings inside");
        }
        active = true;
    }
}
