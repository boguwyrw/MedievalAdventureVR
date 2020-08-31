using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsScript : MonoBehaviour
{
    private ISelectWeaponsScript selectWeaponsScript;
    private float fireDelayTime = 1.5f;
    private float nextFireTime;

    private void Awake()
    {
        selectWeaponsScript = GetComponent<ISelectWeaponsScript>();
        nextFireTime = fireDelayTime;
    }

    void Update()
    {
        fireDelayTime = fireDelayTime - Time.deltaTime;
        /*
        //if (fireDelayTime <= 0.0f)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireWeapon();
            fireDelayTime = nextFireTime;
        }
        */
        FireWeapon();
    }

    private void FireWeapon()
    {
        selectWeaponsScript.UseSelectedWeapon(this);
    }
}
