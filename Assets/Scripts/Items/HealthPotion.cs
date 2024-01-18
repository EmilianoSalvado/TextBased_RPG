using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    [SerializeField] float _healingAmount;
    public override void Use(Character target)
    {
        target.Heal(_healingAmount);
    }
}