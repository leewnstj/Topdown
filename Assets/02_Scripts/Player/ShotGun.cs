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
    [SerializeField] float bulletCount;
    [SerializeField] float bulletSpread;

    public void ShootingShot()
    {
        if (currentShotCool <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                for(int i = 0; i < bulletCount; i++)
                {
                    GameObject bullet = Instantiate(shotBullet, transform.position, transform.rotation);
                    Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();



                    rigid.AddForce((transform.up + new Vector3(Random.Range(-bulletSpread, bulletSpread), Random.Range(-bulletSpread, bulletSpread))) * ShotbulletSpeed, ForceMode2D.Impulse);
                    currentShotCool = ShotShootCool;
                }
            }
        }
        currentShotCool -= Time.deltaTime;
    }
}
