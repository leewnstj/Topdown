using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootSource : MonoBehaviour
{
    
    [SerializeField] protected float attackSpeed;
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected float bulletSpread;
    [SerializeField] protected GameObject bullet;

    private void Update()
    {
        Shooting();
    }

    protected float currentAttack;

    public virtual void Shooting()
    {

    }

    protected void CreateBullet()
    {
        GameObject Bullet = Instantiate(bullet, transform.position, Quaternion.identity);
        Bullet.transform.up = transform.right * -1;
        Rigidbody2D rigid = Bullet.GetComponent<Rigidbody2D>();

        rigid.AddForce((transform.up + new Vector3(Random.Range(-bulletSpread, bulletSpread), Random.Range(-bulletSpread, bulletSpread))) * bulletSpeed, ForceMode2D.Impulse);
    }

}
