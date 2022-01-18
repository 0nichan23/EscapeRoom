using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public List<Room> Rooms = new List<Room>();
    public static RoomManager Instance = new RoomManager();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        Room[] children = GetComponentsInChildren<Room>();
        for (int i = 0; i < children.Length; i++)
        {
            Rooms.Add(children[i]);
        }
    }
}
