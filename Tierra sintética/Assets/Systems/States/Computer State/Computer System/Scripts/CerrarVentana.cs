using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarVentana : MonoBehaviour
{
    public GameObject app;
    public void Cerrar() {
        app.SetActive(false);
    }
    
}
