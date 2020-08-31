using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsScript : MonoBehaviour
{
    private ISelectWeaponsScript selectWeaponsScript;
    private float fireDelayTime = 2.0f;
    private float nextFireTime;

    private void Awake()
    {
        selectWeaponsScript = GetComponent<ISelectWeaponsScript>();
        nextFireTime = fireDelayTime;
    }

    void Update()
    {
        if (CanFire())
        {
            FireWeapon();
        }
    }

    private bool CanFire()
    {
        return Time.time >= nextFireTime;
    }

    private void FireWeapon()
    {
        selectWeaponsScript.UseSelectedWeapon(this);
        nextFireTime = Time.time + fireDelayTime;
    }
}
