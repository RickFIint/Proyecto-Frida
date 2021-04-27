using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class ManipulateObjects : MonoBehaviour
{
    InputMaster _controls;

    bool detected;
    bool taken;

    public Transform target;
    public float speed = 15f;
    public Rigidbody rig;

    void Awake()
    {
        _controls = new InputMaster();

        _controls.Player.Interact.performed += ctx => InteractAction(ctx);
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }


    void InteractAction(InputAction.CallbackContext context)
    {
        if (detected)
        {
            if (!taken)
            {
                taken = true;
            }
            else
            {
                taken = false;
                rig.useGravity = true;
            }
        }
    }

    void Detection()
    {
        Debug.Log("detection");

        detected = true;
    }

    void NoDetection()
    {
        Debug.Log("no detection");

        detected = false;

        if (taken)
        {
            taken = false;
            rig.useGravity = true;
        }
    }

    private void Update()
    {
        if (taken)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            rig.MovePosition(pos);
            rig.useGravity = false;
        }
    }

}
