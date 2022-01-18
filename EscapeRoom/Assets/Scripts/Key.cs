using UnityEngine;

public class Key : Interacteble
{
    bool picked = false;
    Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public override void Activate()
    {
        pickup();
    }

    void pickup()
    {
        player.Additem(this);
        gameObject.SetActive(false);  
        Debug.Log("picked up key");
        active = true;
    }
}
