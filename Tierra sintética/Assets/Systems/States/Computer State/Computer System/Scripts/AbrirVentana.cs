using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirVentana : MonoBehaviour
{
    public GameObject app;

    public void Abrir() {
        app.SetActive(true);
    }
}
