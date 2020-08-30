using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MainCameraScript : MonoBehaviour
{
    private void Awake()
    {
        var inputDevices = new List<InputDevice>();
        

        foreach (var device in inputDevices)
        {
            Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
        }
        /*
        //XRSettings.enabled = false;
        Camera.main.GetComponent<Transform>().localPosition = InputTracking.GetNodeStates(HumanPose);
        //Camera.main.GetComponent<Transform>().localRotation = InputTracking.GetLocalRotation(XRNode.CenterEye);
        */
    }
}
