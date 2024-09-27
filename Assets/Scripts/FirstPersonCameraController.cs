using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float sensitivity = 5.0f;

    private CinemachinePOV povComponent;

    void Start()
    {
        povComponent = virtualCamera.GetCinemachineComponent<CinemachinePOV>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            RotateCamera();
        }
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        povComponent.m_HorizontalAxis.Value += mouseX;
        povComponent.m_VerticalAxis.Value -= mouseY;
    }
}
