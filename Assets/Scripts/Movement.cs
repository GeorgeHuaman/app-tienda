using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6.0f;
    public Transform fpsCamera;
    public CinemachineVirtualCamera firstPersonCamera;

    void Update()
    {
        if (firstPersonCamera.Priority !=0)
        {
            Move();
        }
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = fpsCamera.forward;
        Vector3 right = fpsCamera.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 move = forward * moveZ + right * moveX;

        controller.Move(move * speed * Time.deltaTime);
    }
}
