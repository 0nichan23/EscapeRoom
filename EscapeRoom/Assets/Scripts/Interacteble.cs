using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interacteble : MonoBehaviour
{
    protected bool active = false;
    public Interacteble NeededItem;
    public abstract void Activate();
    public abstract void pickup();

}
