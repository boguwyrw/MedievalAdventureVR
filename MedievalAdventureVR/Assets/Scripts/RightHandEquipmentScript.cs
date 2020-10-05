using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandEquipmentScript : MonoBehaviour, IHandsEquipmentScript
{
    [SerializeField]
    private GameObject rightHand;

    public void GrabEquipment()
    {
        /*
        if (OVRInput.Get(OVRInput.RawButton.A))
        {
            if (grabbedEquipment.layer == 9)
            {
                grabbedEquipment.transform.parent = transform;
            }
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            other.transform.parent = rightHand.transform;
            other.transform.position = rightHand.transform.GetChild(0).transform.position;
        }
    }
}
