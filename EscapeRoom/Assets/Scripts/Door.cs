using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interacteble
{
    public override void Activate()
    {
        active = true;
    }

    private void Update()
    {
        if (active)
        {
            Open();
        }   
    }

    void Open()
    {
        //opens door
    }

    public override void pickup()
    {
        Player.inventory.Add(this);
    }
}
