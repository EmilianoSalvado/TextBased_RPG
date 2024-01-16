using System.Collections.Generic;
using UnityEngine;

public abstract class Armor : MonoBehaviour
{
    [SerializeField][Range(0f,1f)] float _defAgainstSlash;
    [SerializeField][Range(0f,1f)] float _defAgainstPierce;
    [SerializeField][Range(0f,1f)] float _defAgainstBlunt;
    [SerializeField][Range(0f,1f)] float _defAgainstFire;
    [SerializeField][Range(0f,1f)] float _defAgainstIce;
    bool _isGuarding;
    Dictionary<AttackType, float> _defenseValues = new Dictionary<AttackType, float>();

    private void Start()
    {
        _defenseValues.Add(AttackType.Slash, _defAgainstSlash);
        _defenseValues.Add(AttackType.Pierce, _defAgainstPierce);
        _defenseValues.Add(AttackType.Blunt, _defAgainstBlunt);
        _defenseValues.Add(AttackType.Fire, _defAgainstFire);
        _defenseValues.Add(AttackType.Ice, _defAgainstIce);
    }

    public float GetDefense(Weapon weapon)
    {
        var def = _isGuarding ? _defenseValues[weapon.AttackType] * 2f : _defenseValues[weapon.AttackType];
        _isGuarding = false;
        return 1f - def;
    }

    public void Guard()
    {
        _isGuarding = true;
    }
}