using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{

    private void Awake()
    {
        base.SetUp();
    } 

    public float maxHP;
    public float hpRecovery;

    public override float MaxHP => maxHP;

    public override float HPRecovery => hpRecovery;

    public override void TakeDamage(float damage)
    {
        HP -= damage;
    }
}
