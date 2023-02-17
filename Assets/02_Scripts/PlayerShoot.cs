using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPref;

    [SerializeField] float bulletSpeed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPref, firePoint.position, firePoint.rotation);
        Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
        rigid.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
