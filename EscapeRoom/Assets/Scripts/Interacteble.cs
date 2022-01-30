using UnityEngine;

public abstract class Interacteble : MonoBehaviour
{
    protected bool active = false;
    
    public Interacteble NeededItem;
    public abstract void Interact();
    private void OnMouseDown()
    {
        if (!active)
        {
            Interact();
        }

    }
    void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().material.color = Color.green;
    }

    void OnMouseExit()
    {

        GetComponent<SpriteRenderer>().material.color = Color.white;

    }

}
