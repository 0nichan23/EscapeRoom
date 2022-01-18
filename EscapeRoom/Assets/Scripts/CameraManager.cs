using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public int current;


    private void Start()
    {
        current = 0;
        for (int i = 0; i < RoomManager.Instance.Rooms.Count; i++)
        {
            RoomManager.Instance.Rooms[i].gameObject.SetActive(false);
        }
        RoomManager.Instance.Rooms[current].gameObject.SetActive(true);

    }
    public void NextRoom()
    {
        for (int i = 0; i < RoomManager.Instance.Rooms.Count; i++)
        {
            RoomManager.Instance.Rooms[i].gameObject.SetActive(false);
        }
        if (current == RoomManager.Instance.Rooms.Count - 1)
        {
            current = 0;
        }
        else
        {
            current++;
        }
        RoomManager.Instance.Rooms[current].gameObject.SetActive(true);

    }
    public void PreviousRoom()
    {
        for (int i = 0; i < RoomManager.Instance.Rooms.Count; i++)
        {
            RoomManager.Instance.Rooms[i].gameObject.SetActive(false);
        }
        if (current == 0)
        {
            current = RoomManager.Instance.Rooms.Count - 1;
        }
        else
        {
            current--;
        }
        RoomManager.Instance.Rooms[current].gameObject.SetActive(true);


    }
}
