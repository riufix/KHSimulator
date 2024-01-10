using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    public override bool ActiveEffect(GameObject player)
    {
        if (player.TryGetComponent(out PlayerAttack AttackPowerUp))
        {
            AttackPowerUp.AttackPoweUp(5);
            return true;
        }
        return false;
    }
}
