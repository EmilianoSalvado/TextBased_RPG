using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected string _name;
    [SerializeField] protected AttackType _attackType;
    public AttackType AttackType { get { return _attackType; } }
    [SerializeField] protected Class _strongClass;
    [SerializeField] protected Class _weakClass;
    [SerializeField][Range(0f,1f)] protected float _effectChance;
    [SerializeField] protected float _baseDamage;
    float _auxDamage;
    private void Start()
    {
        _auxDamage = _baseDamage;
    }

    public float GetDamage(Character owner)
    {
        var dmg = _baseDamage;

        if (owner.Class == _strongClass)
            dmg *= 1f + owner.Level * .1f;
        else if (owner.Class == _weakClass)
            dmg *= owner.Level * .1f;

        return dmg;
    }

    public void DamagePenalization()
    {
        _baseDamage = _baseDamage == _auxDamage ? _baseDamage : _baseDamage *= .5f;
    }

    public void DamageRecover()
    {
        _baseDamage -= _auxDamage;
    }
}