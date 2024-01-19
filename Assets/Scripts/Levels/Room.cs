using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] Room _northRoom;
    [SerializeField] Room _westRoom;
    [SerializeField] Room _southRoom;
    [SerializeField] Room _eastRoom;
    Dictionary<Direction, Room> _adyacentRooms = new Dictionary<Direction, Room>();
    Dictionary<Direction, bool> _directionsAvailable = new Dictionary<Direction, bool>();
    public Dictionary<Direction, bool> DirectionsAvailable {  get { return _directionsAvailable; } }

    private void Start()
    {
        _adyacentRooms.Add(Direction.North, _northRoom);
        _adyacentRooms.Add(Direction.West, _westRoom);
        _adyacentRooms.Add(Direction.South, _southRoom);
        _adyacentRooms.Add(Direction.East, _eastRoom);
    }
}