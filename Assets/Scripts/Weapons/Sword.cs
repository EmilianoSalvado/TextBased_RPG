using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    [SerializeField][Range(0f, 1f)] float _slashChances;
    [SerializeField] float _slashDamage;
    [SerializeField][Range(0f, 1f)] float _pierceChances;
    [SerializeField] float _pierceDamage;
    public void Slash(Character enemy)
    {
        Actions.Attack(enemy, _slashChances, _slashDamage, States.Bleeding);
    }

    public void Pierce(Character enemy)
    {
        Actions.Attack(enemy, _pierceChances, _pierceDamage, States.Bleeding);
    }
}