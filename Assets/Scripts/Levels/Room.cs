using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    Dictionary<Direction, bool> _directionsAvailable = new Dictionary<Direction, bool>();
    public Dictionary<Direction, bool> DirectionsAvailable {  get { return _directionsAvailable; } }

    public void SetDirectionsAvailable(bool north, bool west, bool south, bool east)
    {
        _directionsAvailable.Clear();
        _directionsAvailable.Add(Direction.North, north);
        _directionsAvailable.Add(Direction.West, west);
        _directionsAvailable.Add(Direction.South, south);
        _directionsAvailable.Add(Direction.East, east);
    }
}