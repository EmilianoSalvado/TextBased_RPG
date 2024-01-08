using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] string _name;
    [SerializeField] AttackType _attackType;
    [SerializeField] AttackEffect _attackEffect;
    [SerializeField][Range(0f,1f)] float _effectChance;
    [SerializeField] float _baseDamage;
}