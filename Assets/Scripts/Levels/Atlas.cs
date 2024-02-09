using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atlas : MonoBehaviour
{
    Dictionary<int[],Room> _roomsExplored = new Dictionary<int[], Room>();

    public static Atlas instance;

    private void Start()
    {
        instance = this;
    }

    public void AddRoom(Room room)
    {
        _roomsExplored.Add(room.Coordinates, room);
    }
}