using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "CameraObject")
        {
            other.GetComponent("PhotographicCamera").SendMessage("Detection");
        }


        if (other.tag == "Object")
        {
            other.GetComponent("ManipulateObjects").SendMessage("Detection");
        }

        if (other.tag == "Board")
        {
            other.GetComponent("BoardObject").SendMessage("Detection");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CameraObject")
        {
            other.GetComponent("PhotographicCamera").SendMessage("NoDetection");
        }

        if (other.tag == "Object")
        {
            other.GetComponent("ManipulateObjects").SendMessage("NoDetection");
        }

        if (other.tag == "Board")
        {
            other.GetComponent("BoardObject").SendMessage("NoDetection");
        }
    }
}
