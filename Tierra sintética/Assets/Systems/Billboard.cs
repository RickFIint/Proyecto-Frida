using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera theCam;


    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(theCam.transform);
    }
}
