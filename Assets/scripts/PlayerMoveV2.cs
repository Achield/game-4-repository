using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveV2 : MonoBehaviour
{
    Rigidbody rb;
    Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void MovePlayerRelativeToCamera()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Getting camera vectors
        Vector3 cameraForward = Camera.main.transform.forward;
        Vector3 cameraRight = Camera.main.transform.right;

        // Remove Y and normalize
        cameraForward.y = 0;
        cameraRight.y = 0;
        cameraForward = cameraForward.normalized;
        cameraRight = cameraRight.normalized;

        // Rotate the input vectors
        Vector3 forwardRelativeMovementVector = v * cameraForward;
        Vector3 rightRelativeMovementVector = h * cameraRight;

        // Create camera-relative movement vector
        Vector3 cameraRelativeMovement = forwardRelativeMovementVector + rightRelativeMovementVector;

        //Move in world space



    }

}
