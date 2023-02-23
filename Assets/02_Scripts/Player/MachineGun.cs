using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    [SerializeField] GameObject machineGunBullet;
    [SerializeField] float ShootCool;
    private float currentCool;
    [SerializeField] float bulletSpeed;

    public void ShootingMachine()
    {
        if(currentCool <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                GameObject bullet = Instantiate(machineGunBullet, transform.position, transform.rotation);
                Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
                rigid.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
            }
            currentCool = ShootCool;
        }
        currentCool -= Time.deltaTime;
    }
}
