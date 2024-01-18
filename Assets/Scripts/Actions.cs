using System;
using UnityEngine;

public static class Actions
{
    public static bool Attack(Character attacker, Character receiver)
    {
        var dmg = attacker.Weapon.GetDamage(attacker);
        var def = receiver.Armor.GetDefense(attacker.Weapon);

        if (UnityEngine.Random.Range(0f, 1f) * attacker.Level < def) return false;

        receiver.TakeDamage(dmg * def);
        return true;
    }

    public static bool Attack(Character receiver, float chances, float damage, Action<Character> effect)
    {
        if (UnityEngine.Random.Range(0f, 1f) > chances) return false;

        receiver.TakeDamage(damage);
        receiver.StateEffect(effect);
        return true;

    }

    public static void Guard(Character character)
    {
        character.Armor.Guard();
    }
}