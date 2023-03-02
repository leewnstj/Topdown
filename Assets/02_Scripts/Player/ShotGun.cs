using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour
{
    [Header("SHOT")]
    [SerializeField] GameObject shotBullet;
    [SerializeField] float ShotShootCool;
    public float currentShotCool;
    [SerializeField] float ShotbulletSpeed;

    public void ShootingShot()
    {
        if (currentShotCool <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject bullet = Instantiate(shotBullet, transform.position, transform.rotation);
                Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
                rigid.AddForce(transform.up * ShotbulletSpeed, ForceMode2D.Impulse);
                currentShotCool = ShotShootCool;
            }
        }
        currentShotCool -= Time.deltaTime;
    }
}
