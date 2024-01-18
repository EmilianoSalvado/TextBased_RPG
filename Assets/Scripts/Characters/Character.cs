using System;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected string _name;
    [SerializeField] protected Class _class;
    public Class Class { get { return _class; } }
    [SerializeField] protected int _level;
    public int Level { get { return _level; } }
    protected float _life;
    [SerializeField] protected float _maxLife;
    public float MaxLife {  get { return _maxLife; } }
    [SerializeField] protected Weapon _weapon;
    public Weapon Weapon { get { return _weapon; } }
    [SerializeField] Armor _armor;
    public Armor Armor { get { return _armor; } }
    bool _skipTurn;
    Action<Character> _stateEffectMethod;

    private void Start()
    {
        _life = _maxLife;
        _stateEffectMethod = (x) => { };
    }
    public void TakeDamage(float dmg)
    {
        _life -= dmg;
        if (_life <= 0) Die();
    }

    public void Heal(float amount)
    {
        _life += _life + amount > _maxLife ? _maxLife : _life + amount;
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

    public void ClearStateEffects()
    {
        _stateEffectMethod = (x) => { };
    }

    public abstract void Die();
}