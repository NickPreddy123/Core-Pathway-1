using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    public float sensitivity = 5.0f;
    public float speed = 10.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        // Get the mouse movement
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotate the camera
        rotationX += mouseY;
        rotationY += mouseX;
        transform.rotation = Quaternion.Euler(-rotationX, rotationY, 0.0f);

        // Move the camera
        float vertical = Input.GetAxis("Vertical") * speed;
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float up = Input.GetKey(KeyCode.E) ? speed : 0.0f;
        float down = Input.GetKey(KeyCode.Q) ? speed : 0.0f;
        transform.position += transform.forward * vertical * Time.deltaTime
                            + transform.right * horizontal * Time.deltaTime
                            + transform.up * (up - down) * Time.deltaTime;

        Cursor.lockState = CursorLockMode.Locked;
    }
}
