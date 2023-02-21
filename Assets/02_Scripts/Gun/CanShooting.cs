using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanShooting : MonoBehaviour
{

    public bool isMachine;
    public bool isRoket;
    public bool isShot;
    private void Update()
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
    }
}
