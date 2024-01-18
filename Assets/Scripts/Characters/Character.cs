using System;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected string _name;
    [SerializeField] protected Class _class;
    public Class Class { get { return _class; } }
    [SerializeField] protected int _level;
    public int Level { get { return _level; } }
    [SerializeField] protected float _life;
    [SerializeField] protected Weapon _weapon;
    public Weapon Weapon { get { return _weapon; } }
    [SerializeField] Armor _armor;
    public Armor Armor { get { return _armor; } }
    bool _skipTurn;
    Action<Character> _stateEffectMethod;
    public void TakeDamage(float dmg)
    {
        _life -= dmg;
        if (_life <= 0) Die();
    }

    public void SkipTurn()
    {
        _skipTurn = true;
    }

    public void StateEffect(Action<Character> stateEffectMethod)
    {
        _stateEffectMethod = stateEffectMethod;
    }

    public void StateEffectTrigger()
    {
        _stateEffectMethod(this);
    }

    public abstract void Die();
}