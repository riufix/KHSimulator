using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    [SerializeField] int _amount;
    public int Amount { get => _amount; private set => _amount = value; }
    public override bool ActiveEffect(GameObject player)
    {
        if (player.TryGetComponent(out EntityHealth health))
        {
            health.HealthUpdate(_amount);
            return true;
        }
        return false;
    }
}
