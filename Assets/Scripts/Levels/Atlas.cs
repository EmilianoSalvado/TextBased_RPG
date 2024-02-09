using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atlas : MonoBehaviour
{
    List<Room> _roomsExplored = new List<Room>();

    public static Atlas instance;

    private void Start()
    {
        instance = this;
    }

    public void AddRoom(Room room)
    {
        _roomsExplored.Add(room);
    }
}