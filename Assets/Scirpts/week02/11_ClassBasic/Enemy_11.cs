using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_11
{
    private Player_11 player;

    public void AttackToTarget(Player_11 target)
    {
        target.TakeDamage(100);
    }
}
