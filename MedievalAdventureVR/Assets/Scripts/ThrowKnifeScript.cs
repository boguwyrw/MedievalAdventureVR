using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowKnifeScript : MonoBehaviour, ISelectWeaponsScript
{
    [SerializeField]
    private Transform knife;

    public void UseSelectedWeapon(WeaponsScript weaponsScript)
    {
        //GameObject cloneKnife = Instantiate(knife.gameObject);
        //cloneKnife.transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        knife.Translate(Vector3.forward * 5 * Time.deltaTime);
    }
}
