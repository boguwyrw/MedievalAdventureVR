using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowKnifeScript : MonoBehaviour, ISelectWeaponsScript
{
    [SerializeField]
    private Transform knife;
    [SerializeField]
    private Transform knifeStartPosition;

    private float knifeThrowForce = 650.0f;

    public void UseSelectedWeapon(WeaponsScript weaponsScript)
    {
        GameObject cloneKnife = Instantiate(knife.gameObject, knifeStartPosition.position, transform.rotation);
        Rigidbody knifeRigidbody = cloneKnife.GetComponent<Rigidbody>();
        knifeRigidbody.velocity = transform.TransformDirection(Vector3.forward * knifeThrowForce * Time.deltaTime);
    }
}
