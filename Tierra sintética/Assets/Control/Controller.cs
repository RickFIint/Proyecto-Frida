using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Controller : MonoBehaviour
{

    InputMaster _controls;

    [Header("Modifier Values")]
    public CharacterController _characterController;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    [Header("Information")]
    public Vector2 direction;
    public Vector3 velocity;
    bool isGrounded;
    bool isJumping = false;

    void Awake()
    {
        _controls = new InputMaster();

        _controls.Player.Interact.performed += ctx => InteractAction(ctx);
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }

        direction = _controls.Player.Move.ReadValue<Vector2>();

        Vector3 movement = transform.right * direction.x + transform.forward * direction.y;

        _characterController.Move(movement * speed * Time.deltaTime);

        if (isJumping && isGrounded) {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        

        velocity.y += gravity * Time.deltaTime;

        _characterController.Move(velocity * Time.deltaTime);
    }

    void InteractAction(InputAction.CallbackContext context) {
        Debug.Log("interact!");
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}
