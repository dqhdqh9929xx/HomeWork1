using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{
    public float rotateSpeed = 150f;
    public Transform cam;

    private float verticalAngle = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Mouse X");
        float moveY = Input.GetAxis("Mouse Y");

        float horizontalAngle = moveX * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, horizontalAngle, 0);

        verticalAngle -= moveY * rotateSpeed * Time.deltaTime;
        verticalAngle = Mathf.Clamp(verticalAngle, -90f, 90f);

        cam.localRotation = Quaternion.Euler(verticalAngle, 0f, 0f);
    }
}
