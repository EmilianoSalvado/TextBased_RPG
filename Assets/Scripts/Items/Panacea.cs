using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panacea : Item
{
    public override void Use(Character target)
    {
        target.Heal(target.MaxLife);
        target.ClearStateEffects();
    }
}
