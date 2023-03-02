using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : ShootSource
{

    public override void Shooting()
    {
        if(currentAttack <= 0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                CreateBullet();
            }
        }
        currentAttack -= Time.deltaTime;
    }
}
