using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootSource : MonoBehaviour
{
    
    [SerializeField] protected float attackSpeed;
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected float bulletSpread;

    public abstract void Shooting();

}
