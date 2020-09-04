using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVRMovingScript : MonoBehaviour
{
    [SerializeField]
    private Transform handRight;
    [SerializeField]
    private Transform handLeft;
    [SerializeField]
    private CapsuleCollider capsuleCollider;
    [SerializeField]
    private Transform cameraTransform;

    private Vector2 rightStick;
    private Vector2 leftStick;

    private float walkingSpeed = 3.0f;
    private float rotationSpeed = 25.0f;
    private float playerSpeed = 0.0f;
    private float difference = 0.15f;

    private void Awake()
    {
        playerSpeed = walkingSpeed;
    }

    private void Update()
    {
        HandsMovement();
        PlayersWalking();
        PlayersRotating();
        PlayersHeight();
    }

    private void HandsMovement()
    {
        handRight.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        handRight.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

        handLeft.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        handLeft.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
    }

    private void PlayersWalking()
    {
        rightStick = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        if (rightStick.y > 0.0f)
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if (rightStick.y < 0.0f)
        {
            transform.Translate(Vector3.back * playerSpeed * Time.deltaTime);
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

    private void PlayersHeight()
    {
        capsuleCollider.height = cameraTransform.position.y + difference;
    }
}
