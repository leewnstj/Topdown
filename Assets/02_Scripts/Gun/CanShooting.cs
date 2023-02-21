using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CanShooting : MonoBehaviour
{

    public bool isMachine;
    public bool isRoket;
    public bool isShot;
    private void Update()
    {
        Shooting();
    }

    public UnityEvent<bool,bool,bool> canShoot;


    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            isMachine = true;
            isRoket = false;
            isShot = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            isMachine = false;
            isRoket = true;
            isShot = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            isMachine = false;
            isRoket = false;
            isShot = true;
        }

        canShoot?.Invoke(isMachine, isRoket, isShot);
    }
}
