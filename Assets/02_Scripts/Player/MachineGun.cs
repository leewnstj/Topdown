using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    [Header("MACHINEGUN")]
    [SerializeField] GameObject machineGunBullet;
    [SerializeField] float MachineShootCool;
    private float currentMachineCool;
    [SerializeField] float MachinebulletSpeed;
    [SerializeField] float bulletSpread;


    public void ShootingMachine()
    {
        if(currentMachineCool <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                GameObject bullet = Instantiate(machineGunBullet, transform.position, Quaternion.identity);
                bullet.transform.up = transform.right * -1;
                Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
                

                rigid.AddForce((transform.up + new Vector3(Random.Range(-bulletSpread, bulletSpread), Random.Range(-bulletSpread, bulletSpread))) * MachinebulletSpeed, ForceMode2D.Impulse);
                currentMachineCool = MachineShootCool;
            }
        }
        currentMachineCool -= Time.deltaTime;
    }
}
