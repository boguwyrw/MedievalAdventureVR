using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVRScript : MonoBehaviour
{
    [SerializeField]
    private Transform rightHand;
    [SerializeField]
    private Transform leftHand;

    private Vector2 rightStick;
    private Vector2 leftStick;

    private float walkingSpeed = 3.0f;
    private float rotationSpeed = 25.0f;
    private float characterSpeed = 0.0f;

    private void Awake()
    {
        characterSpeed = walkingSpeed;
    }

    private void Update()
    {
        HandsMovement();
        PlayersWalking();
        PlayersRotating();
    }

    private void HandsMovement()
    {
        rightHand.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        rightHand.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

        leftHand.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        leftHand.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
    }

    private void PlayersWalking()
    {
        rightStick = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        if (rightStick.y > 0.0f)
        {
            transform.Translate(Vector3.forward * characterSpeed * Time.deltaTime);
        }
        if (rightStick.y < 0.0f)
        {
            transform.Translate(Vector3.back * characterSpeed * Time.deltaTime);
        }
    }

    private void PlayersRotating()
    {
        leftStick = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        if (leftStick.x > 0.0f)
        {
            transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f);
        }
        if (leftStick.x < 0.0f)
        {
            transform.Rotate(0.0f, -rotationSpeed * Time.deltaTime, 0.0f);
        }
    }
}
