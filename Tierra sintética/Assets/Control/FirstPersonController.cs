using Microsoft.CSharp.RuntimeBinder;
using System.Collections;
using System.Collections.Generic;
using ECM.Controllers;
using UnityEngine;
using UnityEngine.InputSystem;
using SensorToolkit;
using Yarn;

public class FirstPersonController : BaseFirstPersonController
{
    InputMaster _control;
    private bool onJump = false;
    private bool onCrouch = false;
    private bool onDialogue = false;

    public float cameraStandingHeightDiference = 1.0f;
    public float cameraCrouchingHeightDiference = 0.5f;


    

    public Transform modelTransform { get; private set; }

    [SerializeField] private RaySensor viewSensor;
    [SerializeField] private Animator AnimatorController;
    
    public override void Awake() {

        // Initalize BaseFirstPersonController

            base.Awake();


        _control = new InputMaster();
        _control.Player.Jump.performed += ctx => OnJump(ctx);
        _control.Player.Crouch.performed += ctx => OnCrouch(ctx);
        _control.Player.Interact.started += ctx => OnInteract(ctx);

        viewSensor = GetComponentInChildren<RaySensor>();
        

        modelTransform = transform.Find("Model");
        {
            if (modelTransform == null)
            {
                Debug.LogError(
                    string.Format(
                        "FPSController: model don'n found. Please parent a camera to '{0}' game object.", name));
            }
        }
    }

    protected override void Animate()
        {
            // Add animator related code here...
        }

    protected override void AnimateView()
        {
            // Scale camera pivot to simulate crouching

            var yScale = isCrouching ? Mathf.Clamp01(crouchingHeight / standingHeight) : 1.0f;

            modelTransform.localScale = Vector3.MoveTowards(modelTransform.localScale,
                new Vector3(1.0f, yScale, 1.0f), 5.0f * Time.deltaTime);

            
            
            if (isCrouching) {
                cameraPivotTransform.localPosition = Vector3.MoveTowards(cameraPivotTransform.localPosition, new Vector3(0.0f, 0.5f, 0.0f), 5.0f * Time.deltaTime);
                modelTransform.localPosition = (cameraPivotTransform.localPosition - new Vector3(0.0f, 0.0f, 0.0f));
                
                // AnimatorController.SetBool("Crouching", true);
            } else { 
                cameraPivotTransform.localPosition = new Vector3(0.0f, 1.5f, 0.0f);
                modelTransform.localPosition = new Vector3(0.0f, 1.0f, 0.0f);
                // AnimatorController.SetBool("Crouching", false);  
                }
        }

    protected override void HandleInput()
    {
        // Handle your custom input here...

        Vector2 direction = _control.Player.Move.ReadValue<Vector2>();

        moveDirection = new Vector3
        {
            x = direction.x,
            y = 0.0f,
            z = direction.y
        };

        jump = onJump;

        crouch = onCrouch;
        // Debug.Log(onJump);
        // Replace the above code with your custom input code
    }

    public void OnDialogueEnd() {
            onDialogue = false;
    }

    void OnJump(InputAction.CallbackContext context) {
        onJump = context.ReadValueAsButton();
        // Debug.Log(onJump);
    }

    void OnCrouch(InputAction.CallbackContext context) {
        onCrouch = context.ReadValueAsButton();
        // Debug.Log(onCrouch);
    }

    private void OnInteract(InputAction.CallbackContext context) {

        if (viewSensor.IsObstructed) {
            if (!onDialogue) {
                var npcs = viewSensor.GetDetectedByComponent<Yarn.Unity.NPC>();
                var target = npcs.Find(delegate (Yarn.Unity.NPC p) { 
                
                return string.IsNullOrEmpty(p.talkToNode) == false;
                });
                if (target != null) {
                    FindObjectOfType<Yarn.Unity.DialogueRunner>().StartDialogue(target.talkToNode);
                }
                onDialogue = true;
            }
        }
    }
    private void OnEnable()
    {
        _control.Player.Enable();
    }

    private void OnDisable()
    {
        _control.Player.Disable();
    }

}
