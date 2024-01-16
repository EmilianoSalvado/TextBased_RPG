using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class States
{
    public static void Bleeding(Character affected)
    {
        affected.TakeDamage(10f);
    }

    public static void Mauled(Character affected)
    {
        affected.Weapon.DamagePenalization();
    }

    public static void Burnt(Character affected)
    {
        affected.TakeDamage(15f);
    }

    public static void Frozen(Character affected)
    {
        affected.SkipTurn();
    }
}