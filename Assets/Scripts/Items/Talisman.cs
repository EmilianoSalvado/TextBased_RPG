using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talisman : Item
{
    public override void Use(Character target)
    {
        target.ClearStateEffects();
    }
}