using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ItemObject : MonoBehaviour
{
    InputMaster _control;
    private bool isAlreadyopen = false;
    public TMP_Text text;

    private Vector3 deadZone;

    public GameObject app;

    private Vector3 mousePosition;

    private Vector3 mousePoint;
    private Vector3 startMousePosition;
    private Vector3 startDistance;

    private bool isPresed = false;
    private bool isCreated = false;
    private bool isHold = false;

    private Vector3 distanceTraveled;
    private Vector3 unholdBottomPosition;

    private float zCoord;

    void Awake()
    {
        _control = new InputMaster();


        _control.TableOfClues.LeftClick.performed += ctx => OnLeftClick(ctx);
        _control.TableOfClues.LeftClick.canceled += ctx => RealiseLeftClick(ctx);
    }

    public void MouseAction()
    {
        if (!app.activeInHierarchy) {
            isCreated = false;
            //Debug.Log("destruida");
        }
        
        unholdBottomPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        distanceTraveled = unholdBottomPosition - startDistance;

        if (isPresed == true && distanceTraveled.magnitude > deadZone.magnitude)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(_control.TableOfClues.MousePosition.ReadValue<Vector2>());

            startMousePosition = gameObject.transform.localPosition - mousePosition;

            this.gameObject.transform.position = mousePoint - startMousePosition;
            Debug.Log("OnLeftClick");

            isHold = true;
        }
    }
        
    void OnLeftClick(InputAction.CallbackContext context) {

        zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        

        mousePoint = new Vector3(_control.TableOfClues.MousePosition.ReadValue<Vector2>().x, 
        _control.TableOfClues.MousePosition.ReadValue<Vector2>().x, zCoord);

        mousePosition = Camera.main.ScreenToWorldPoint(mousePoint);

        deadZone = transform.position - mousePosition;

        //startMousePosition = mousePosition - gameObject.transform.localPosition;


        Debug.Log("LeftClick");

        isPresed = true;        
    }

    void RealiseLeftClick(InputAction.CallbackContext context) {

        if (!isCreated && !isHold)
        {
            app.SetActive(true);
            isCreated = true;
            if (!isAlreadyopen)
            {
                text.enabled = false;
                isAlreadyopen = true;
            }
        }

        isHold = false;
        isPresed = false;
    }

    private void OnEnable()
    {
        _control.TableOfClues.Enable();
    }

    private void OnDisable()
    {
        _control.TableOfClues.Disable();
    }
}

