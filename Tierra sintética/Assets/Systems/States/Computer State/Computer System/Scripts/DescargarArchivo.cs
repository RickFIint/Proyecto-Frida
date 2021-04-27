using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescargarArchivo : MonoBehaviour
{

    public GameObject manual;
    public GameObject manual2;

    public void Download() {
        manual.SetActive(true);
        manual2.SetActive(true);
    }
}
