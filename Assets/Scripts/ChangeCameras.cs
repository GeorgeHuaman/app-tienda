using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCameras : MonoBehaviour
{
    public CinemachineVirtualCamera firstPersonCamera;
    public CinemachineVirtualCamera topDownCamera;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        // Inicialmente activar la c�mara FPS
        firstPersonCamera.Priority = 10;
        topDownCamera.Priority = 0;
    }

    public void SwitchCamera()
    {
        if (firstPersonCamera.Priority > topDownCamera.Priority)
        {
            // Cambiar a la c�mara TopDown (ortogr�fica)
            firstPersonCamera.Priority = 0;
            topDownCamera.Priority = 10;
        }
        else
        {
            // Cambiar a la c�mara FPS (perspectiva)
            firstPersonCamera.Priority = 10;
            topDownCamera.Priority = 0;
        }
    }
}
