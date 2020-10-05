using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootsScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody arrowRigidbody;

    private void Update()
    {
        Shooting();
    }

    private void Shooting()
    {
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            arrowRigidbody.constraints = RigidbodyConstraints.None;
            arrowRigidbody.transform.parent = null;
            arrowRigidbody.AddForce(arrowRigidbody.transform.TransformDirection(Vector3.back) * 4000 * Time.deltaTime, ForceMode.Force);
            arrowRigidbody.useGravity = true;
        }
    }
}
