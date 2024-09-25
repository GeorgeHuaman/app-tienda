using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float sensitivity = 2.0f;
    public float minYAngle = -40f;
    public float maxYAngle = 40f;

    private float rotationY = 0f;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            rotationY -= mouseY;
            rotationY = Mathf.Clamp(rotationY, minYAngle, maxYAngle);

            transform.localRotation = Quaternion.Euler(rotationY, transform.localEulerAngles.y + mouseX, 0);
        }
    }
}
