using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] string _name;
    [SerializeField] Class _class;
    [SerializeField] int _level;
    [SerializeField] float _life;
    [SerializeField] Weapon _weapon;
    [SerializeField] Armor _armor;

    public void TakeDamage(float dmg)
    {
        _life -= dmg;
        if (_life <= 0) Die();
    }

    public abstract void Die();
}