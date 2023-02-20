using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Stats
{
    [HideInInspector] public float HP;
}
public abstract class Entity : MonoBehaviour
{
    private Stats stats;
    public Entity target;
    public float HP
    {
        set => stats.HP = Mathf.Clamp(value, 0, MaxHP);
        get => stats.HP;
    }
    public abstract float MaxHP      { get; }
    public abstract float HPRecovery { get; }

    protected void SetUp()
    {
        HP = MaxHP;
        StartCoroutine(Recovery());
    }

    protected IEnumerator Recovery()
    {
        while (true)
        {
            if (HP < MaxHP) HP += HPRecovery;
            yield return new WaitForSeconds(1);
        }
    }

    public abstract void TakeDamage(float damage);
}
