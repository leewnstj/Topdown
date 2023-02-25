using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ShootInput : MonoBehaviour
{
    [Header("Change Gun")]
    [SerializeField] float ChangeCoolTime;
    public float currentChangeTime;

    [Header("Bool")]
    public bool isMachineGun;
    public bool isShootGun;
    public bool isRoketLauncher;

    [Header("UnityEvents")]
    public UnityEvent machine;
    public UnityEvent shoot;
    public UnityEvent roket;

    private void Start()
    {
        isMachineGun = true;
    }

    private void Update()
    {
        if(currentChangeTime <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                isMachineGun = true;
                isShootGun = false;
                isRoketLauncher = false;
                currentChangeTime = ChangeCoolTime;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                isShootGun = true;
                isMachineGun = false;
                isRoketLauncher = false;
                currentChangeTime = ChangeCoolTime;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                isRoketLauncher = true;
                isMachineGun = false;
                isShootGun = false;
                currentChangeTime = ChangeCoolTime;
            }
        }
        currentChangeTime -= Time.deltaTime;

        if (isMachineGun)
        {
            machine.Invoke();
        }
        else if (isShootGun)
        {
            shoot.Invoke();
        }
        else if(isRoketLauncher)
        {
            roket.Invoke();
        }
    }    
}
