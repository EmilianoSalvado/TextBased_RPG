using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    Dictionary<Direction, bool> _directionsAvailable = new Dictionary<Direction, bool>();
    public Dictionary<Direction, bool> DirectionsAvailable {  get { return _directionsAvailable; } }
    int[] _coordinates = new int[2];
    public int[] Coordinates { get { return _coordinates; } }

    public Room(int x, int y, bool north, bool west, bool south, bool east)
    {
        _coordinates[0] = x;
        _coordinates[1] = y;

        _directionsAvailable.Clear();
        _directionsAvailable.Add(Direction.North, north);
        _directionsAvailable.Add(Direction.West, west);
        _directionsAvailable.Add(Direction.South, south);
        _directionsAvailable.Add(Direction.East, east);
    }
}