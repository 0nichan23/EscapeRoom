using UnityEngine;
public class Door : Interacteble
{
    Player player;
    public override void Interact()
    {
        if (player.inventory.Contains(NeededItem))
        {
            Open();
        }
        else
        {
            Debug.Log("didnt find key");
            AudioManager.Instance.Play(gameObject.GetComponent<AudioSource>().clip);
        }
    }

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Open()
    {
        Debug.Log("door opens");
        active = true;
        ViewManager.Instance.NextRoom();
        AudioManager.Instance.Play(gameObject.GetComponents<AudioSource>()[1].clip);

    }

}
