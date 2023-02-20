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
}
