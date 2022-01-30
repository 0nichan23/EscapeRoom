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
                AudioManager.Instance.Play(gameObject.GetComponent<AudioSource>().clip);
            }
            
        }
        else
        {
            Open();
            AudioManager.Instance.Play(gameObject.GetComponent<AudioSource>().clip);
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
            AudioManager.Instance.Play(gameObject.GetComponent<AudioSource>().clip);
        }
        else
        {
            Debug.Log("nothings inside");
        }
        active = true;
    }
}
