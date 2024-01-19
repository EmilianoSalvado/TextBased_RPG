using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    public void Generate(Room previous, Direction comingFrom)
    {

    }

    bool PossibleDeadEnd(Room previous, Direction comingFrom)
    {
        var count = 0;

        foreach (var dirNRoom in previous.DirectionsAvailable)
        {
            if (dirNRoom.Key == comingFrom || !dirNRoom.Value)
                continue;

            count++; 
        }
        if (count > 1)
            return true;

        return false;
    }
}