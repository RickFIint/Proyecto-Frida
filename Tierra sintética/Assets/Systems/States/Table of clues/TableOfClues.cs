using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SensorToolkit;
using UnityEngine.InputSystem;

public enum TableOfCluesState {STARTSTATE, NAVIGATING, QUITTING, OUTSTATE}
public class TableOfClues : MonoBehaviour
{
    static public TableOfClues S;
    public TableOfCluesState state;
    InputMaster _control;
    public Transform playerPosition;
    private GameObject player;

    private List<ColgableObject> questions;
    public RaySensor viewSensor;



    public virtual void Awake() {
        S = this;

        _control = new InputMaster();
        _control.Player.Interact.canceled += ctx => OnInteract(ctx);
        
        player = GameObject.FindGameObjectWithTag("Player");

        foreach (GameObject aColgableObj in GameObject.FindGameObjectsWithTag("Question"))
        {
            if (questions == null) {
            questions = new List<ColgableObject>();
        }
            questions.Add(aColgableObj.GetComponent<ColgableObject>());
        }

        state = TableOfCluesState.OUTSTATE;
    }

    void Update() {        
        OnTableOfCluesState();
    }

    public void StartTableOfCluesState() {

        if (state != TableOfCluesState.OUTSTATE)
            return;

        state = TableOfCluesState.STARTSTATE;
        
        //setup 
        player.GetComponent<ECM.Components.MouseLook>().SetCursorLock(false);
        player.GetComponent<ECM.Components.MouseLook>().enabled = false;
        player.GetComponent<Collider>().enabled = false;
        player.GetComponent<FirstPersonController>().enabled = false;

        //Head movement position setup
        LeanTween.moveLocal(player, playerPosition.transform.localPosition, 0.5f).setEaseOutQuad();
        LeanTween.rotateY(player, playerPosition.transform.rotation.eulerAngles.y, 0.5f).setEaseOutQuad();
        LeanTween.rotateX(Camera.main.gameObject, playerPosition.rotation.eulerAngles.x, 0.5f).setEaseOutQuad();
        

        player.GetComponent<Rigidbody>().velocity = Vector3.zero; 

        //Debug.Log("start Tabla de pistas");

        state = TableOfCluesState.NAVIGATING;
    }

    public void OnTableOfCluesState(){

        if (state == TableOfCluesState.QUITTING) {
                           
            QuittingTableOfCluesState();
        } else if (state != TableOfCluesState.NAVIGATING) {
            //Debug.Log("Fuera de Tabla de pistas"); 
            return;
        }

        //Navigation behaivior
        foreach (ColgableObject colgObj in questions) {
            colgObj.OnClickDrag();
        }
        
        Debug.Log("En Tabla de pistas");

    }

    public void QuittingTableOfCluesState() {

        //Quiting set up 
        player.GetComponent<ECM.Components.MouseLook>().SetCursorLock(true);
        player.GetComponent<Collider>().enabled = true;
        player.GetComponent<ECM.Components.MouseLook>().enabled = true;
        player.GetComponent<FirstPersonController>().enabled = true; 
        //Debug.Log("Quiting Tabla de pistas");
        
        state = TableOfCluesState.OUTSTATE;
    }

    private void OnInteract(InputAction.CallbackContext context) {
            
            if (state == TableOfCluesState.NAVIGATING) {
                state = TableOfCluesState.QUITTING;
            }

            if (viewSensor.ObstructedBy.gameObject.tag == "TableOfClues") {
                StartTableOfCluesState();
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
