using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketLauncher : PlayerShoot
{
    private void Awake()
    {
        base.SetUP();
    }

    public override void TakeDamage(float damage)
    {
        
    }

    [SerializeField] float maxBullet;



    public override float MaxBulletCount => maxBullet;
}
