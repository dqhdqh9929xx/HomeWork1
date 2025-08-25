using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKey : MonoBehaviour
{
    public CharacterController ctrl;
    public float speed;

    private void OnValidate() => ctrl = GetComponent<CharacterController>();

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 dir = transform.right * x + transform.forward * z;
        ctrl.SimpleMove(dir * speed);
    }
}
