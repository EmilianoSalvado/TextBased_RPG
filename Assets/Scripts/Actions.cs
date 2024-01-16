using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Actions
{
    public static void Attack (Character attacker, Character receiver)
    {
        receiver.TakeDamage(attacker.Weapon.GetDamage(attacker) * receiver.Armor.GetDefense(attacker.Weapon));
    }

    public static void Guard (Character character)
    {
        character.Armor.Guard();
    }
}