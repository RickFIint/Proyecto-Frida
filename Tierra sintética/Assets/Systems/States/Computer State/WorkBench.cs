using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SensorToolkit;
using UnityEngine.InputSystem;

public class WorkBench : MonoBehaviour
{
    public Transform wbHeadPosition;
    public GameObject player;
    public GameObject cam;

    public bool _onWorkBench;

    private void Awake() {
        _onWorkBench = false;
    }

    private void LateUpdate() {
        if (_onWorkBench){
            OnWorkBenchState(true);
        }
    }

    public void StartWorkBenchState() {
        
        //set up 
        _onWorkBench = true;
        player.GetComponent<ECM.Components.MouseLook>().SetCursorLock(false);
        player.GetComponent<Collider>().enabled = false;
        player.GetComponent<ECM.Components.MouseLook>().enabled = false;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        //movimiento
        LeanTween.moveLocal(player, wbHeadPosition.position, 1.0f).setEaseOutQuad();
        LeanTween.rotateY(player, wbHeadPosition.transform.rotation.eulerAngles.y, 1.0f).setEaseOutQuad();
        LeanTween.rotateX(cam, wbHeadPosition.rotation.eulerAngles.x, 1.0f).setEaseOutQuad();
    }

    public void OnWorkBenchState(bool value) {
        Debug.Log("OnWorkBench");

        _onWorkBench = value;
        if (!_onWorkBench) {
            //Quiting set up 
            player.GetComponent<ECM.Components.MouseLook>().SetCursorLock(true);
            player.GetComponent<Collider>().enabled = true;
            player.GetComponent<ECM.Components.MouseLook>().enabled = true;
            player.GetComponent<FirstPersonController>().enabled = true; 
        }
    }
}
