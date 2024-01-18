using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{
    [SerializeField][Range(0f, 1f)] float _maulChances;
    [SerializeField] float _maulDamage;

    public void BreakBones(Character enemy)
    {
        Actions.Attack(enemy, _maulChances, _maulDamage, States.Mauled);
    }
}
