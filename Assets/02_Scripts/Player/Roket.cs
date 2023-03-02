using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : MonoBehaviour
{

    [Header("ROKET")]
    [SerializeField] GameObject roketBullet;
    [SerializeField] float RoketShootCool;
    public float currentRoketCool;
    [SerializeField] float RoketbulletSpeed;

    public void ShootingRoket()
    {
        if (currentRoketCool <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject bullet = Instantiate(roketBullet, transform.position, transform.rotation);
                Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
                rigid.AddForce(transform.up * RoketbulletSpeed, ForceMode2D.Impulse);
                currentRoketCool = RoketShootCool;
            }
        }
        currentRoketCool -= Time.deltaTime;
    }
}
