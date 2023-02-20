using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct GunStats
{
    [HideInInspector] public float bulletCount;
}
public abstract class PlayerShoot : MonoBehaviour
{
    private GunStats gStats;

    public bool canMachine;
    public bool canRoket;
    public bool canShot;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            canMachine = true;
            canRoket = false;
            canShot = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            canRoket = true;
            canMachine = false;
            canShot = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            canShot = true;
            canMachine = false;
            canRoket = false;
        }
    }


    public float bulletCount
    {
        set => gStats.bulletCount = Mathf.Clamp(value, 0, MaxBulletCount);
        get => gStats.bulletCount;
    }

    public abstract float MaxBulletCount { get; }

    protected void SetUP()
    {
        bulletCount = MaxBulletCount;
    }

    public abstract void TakeDamage(float damage);
}
