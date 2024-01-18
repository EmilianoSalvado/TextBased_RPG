using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    [SerializeField][Range(0f, 1f)] float _burningChances;
    [SerializeField] float _burningDamage;
    [SerializeField][Range(0f, 1f)] float _freezingChances;
    [SerializeField] float _freezingDamage;

    public void FireBall(Character enemy)
    {
        Actions.Attack(enemy, _burningChances, _burningDamage, States.Burnt);
    }

    public void IceStake(Character enemy)
    {
        Actions.Attack(enemy, _freezingChances, _freezingDamage, States.Frozen);
    }
}
