using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    Dictionary<Direction, Func<int[], int[]>> _coordinatesCalculation = new Dictionary<Direction, Func<int[], int[]>>();
    Func<bool> _randomizeBool;

    private void Start()
    {
        _coordinatesCalculation.Add(Direction.North, (x) => new int[] { x[0], x[1] - 1 });
        _coordinatesCalculation.Add(Direction.West, (x) => new int[] { x[0] + 1, x[1] });
        _coordinatesCalculation.Add(Direction.South, (x) => new int[] { x[0], x[1] + 1 });
        _coordinatesCalculation.Add(Direction.East, (x) => new int[] { x[0] - 1, x[1] });

        _randomizeBool = () => UnityEngine.Random.Range(0, 2) > 0 ?  true : false;
    }

    public Room Generate(Room previous, Direction comingFrom)
    {
        var newCoo = _coordinatesCalculation[comingFrom](previous.Coordinates);

        bool north = _randomizeBool();
        bool west = _randomizeBool();
        bool south = _randomizeBool();
        bool east = _randomizeBool();

        switch (comingFrom)
        {
            case Direction.North:
                north = true;
                break;
            case Direction.West:
                west = true;
                break;
            case Direction.South:
                south = true;
                break;
            case Direction.East:
                east = true;
                break;
        }

        return new Room(newCoo[0], newCoo[1], north, west, south, east);
    }

    //bool PossibleDeadEnd(Room previous, Direction comingFrom)
    //{

    //}
}