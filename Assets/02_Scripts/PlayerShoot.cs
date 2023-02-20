using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPref;

    [SerializeField] float bulletSpeed;

    public bool canMachine;
    public bool canShot;
    public bool canRoket;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            canMachine = true;
            canShot = false;
            canRoket = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            canShot = true;
            canMachine = false;
            canRoket = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            canRoket = true;
            canMachine = false;
            canShot = false;
        }

        if (canRoket && Input.GetMouseButtonDown(0))
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
