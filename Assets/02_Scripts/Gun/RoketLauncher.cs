using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketLauncher : Entity
{

    public float maxHP;
    public float HPRe;
    public float MaxBullet;
    public override float MaxHP => maxHP;

    public override float HPRecovery => HPRe;

    public override float MaxBulletCount => MaxBullet;

    public override void TakeDamage(float damage)
    {
        HP -= damage;
    }
}
