using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera1 : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
