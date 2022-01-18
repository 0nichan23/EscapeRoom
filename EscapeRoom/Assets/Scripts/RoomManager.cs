using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    List<Room> Rooms = new List<Room>();
    public static RoomManager Instance = new RoomManager();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Instance = this;
        }
    }
}
