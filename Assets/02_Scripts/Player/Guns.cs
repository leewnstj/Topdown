using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    [Header("MACHINEGUN")]
    [SerializeField] GameObject machineGunBullet;
    [SerializeField] float MachineShootCool;
    private float currentMachineCool;
    [SerializeField] float MachinebulletSpeed;

    public void ShootingMachine()
    {
        if(currentMachineCool <= 0)
        {

            Debug.Log(1);

            if (Input.GetMouseButton(0))
            {
                GameObject bullet = Instantiate(machineGunBullet, transform.position, transform.rotation);
                Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
                rigid.AddForce(transform.up * MachinebulletSpeed, ForceMode2D.Impulse);
                currentMachineCool = MachineShootCool;
            }
        }
        currentMachineCool -= Time.deltaTime;
    }
}
