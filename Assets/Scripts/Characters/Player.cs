using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public override void Die()
    {
        Debug.Log("YOU DIED");
    }
}