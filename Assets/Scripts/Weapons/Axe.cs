using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon
{
    [SerializeField][Range(0f, 1f)] float _pierceChances;
    [SerializeField] float _pierceDamage;
    [SerializeField][Range(0f, 1f)] float _maulChances;
    [SerializeField] float _maulDamage;

    public void HardStrike(Character enemy)
    {
        Actions.Attack(enemy, _pierceChances, _pierceDamage, States.Bleeding);
        if (Random.Range(0f, 1f) > .2f) return;
        Actions.Attack(enemy, _maulChances, _maulDamage, States.Mauled);
    }
}