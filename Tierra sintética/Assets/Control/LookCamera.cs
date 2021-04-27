using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class LookCamera : MonoBehaviour
{

    public InputMaster _controls;
    Vector2 delta;
    float xRotation = 0f;

    [Header("Modifier Values")]
    public float mouseSensitivity = 100f;
    public Transform playerBody;


    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _controls = new InputMaster();
    }

    private void Update()
    {
        float mouseX = _controls.Player.RotationX.ReadValue<float>() * mouseSensitivity * Time.deltaTime;
        float mouseY = _controls.Player.RotationY.ReadValue<float>() * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void OnEnable()
    {
        _controls.Player.Enable();
    }

    private void OnDisable()
    {
        _controls.Player.Disable();
    }
}
