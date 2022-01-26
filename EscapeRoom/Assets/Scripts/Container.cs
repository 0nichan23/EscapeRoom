using UnityEngine;

public class Container : Interacteble
{
    public Interacteble itemInside;
    public bool locked;
    Player player;
    public override void Interact()
    {
        if (locked)
        {
            if (player.inventory.Contains(NeededItem))
            {
                Open();
            }
        }
        else
        {
            Open();
        }
    }
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Open()
    {
        if (itemInside != null)
        {
            itemInside.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("nothings inside");
        }
        active = true;
    }
}
