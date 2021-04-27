using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using SensorToolkit;

public class ColgableObject : MonoBehaviour
{
    InputMaster _control;
    private bool isAlreadyopen = false;
    private float deadZoneMaxDistance = 0.001f;

    private Vector3 mousePosition;
    private Vector3 startMousePosition;
    private Vector3 startDistance;

    private bool isPresed = false;
    private bool isCreated = false;

    private Vector3 distanceTraveled;
    private Vector3 unholdBottomPosition;

    private RaySensor viewSensor;
    RaycastHit tableRaycastHit;

    // Start is called before the first frame update
    void Awake()
    {
        _control = new InputMaster();


        _control.TableOfClues.LeftClick.performed += ctx => OnLeftClick(ctx);
        _control.TableOfClues.LeftClick.canceled += ctx => RealiseLeftClick(ctx);

        viewSensor = GameObject.FindGameObjectWithTag("ViewSensor").GetComponent<RaySensor>();

        tableRaycastHit = new RaycastHit();
    }

    public void OnClickDrag() {

        Ray ray = Camera.main.ScreenPointToRay(_control.TableOfClues.MousePosition.ReadValue<Vector2>());

        viewSensor.WorldSpace = true;
        viewSensor.Direction = ray.direction;

        unholdBottomPosition = viewSensor.ObstructionRayHit.point.normalized;
        distanceTraveled = unholdBottomPosition - startDistance;

        //Debug.Log("Ray hit with" + viewSensor.ObstructedBy.gameObject.tag)
        
        
        if (isPresed && distanceTraveled.magnitude > deadZoneMaxDistance)
            {
                //Debug.Log(distanceTraveled.magnitude - deadZoneMaxDistance);
                

                if (viewSensor.DetectedObjectRayHits != null)
                {
                    foreach (RaycastHit q in viewSensor.DetectedObjectRayHits)
                    {                   
                        if (q.collider.gameObject == this.gameObject){
                            mousePosition = viewSensor.ObstructionRayHit.point;
                            
                            this.gameObject.transform.position = new Vector3(mousePosition.x - startMousePosition.x,
                            mousePosition.y - startMousePosition.y, (viewSensor.ObstructionRayHit.point.z + 0.02f));
                        }
                    } 
                }    
            }  
    }

    void OnLeftClick(InputAction.CallbackContext context) {

        mousePosition = viewSensor.ObstructionRayHit.point.normalized;

        startMousePosition.x = mousePosition.x - this.transform.position.normalized.x;
        startMousePosition.y = mousePosition.y - this.transform.position.normalized.y;

        startDistance = viewSensor.ObstructionRayHit.point.normalized; 

        isPresed = true; 
        Debug.Log("Presionado!");
    }

    void RealiseLeftClick(InputAction.CallbackContext context) {
        isPresed = false;
        Debug.Log("Suelto!");
    }

    private void OnDrawGizmos() {
        Gizmos.DrawSphere(viewSensor.ObstructionRayHit.point, 0.1f);
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
