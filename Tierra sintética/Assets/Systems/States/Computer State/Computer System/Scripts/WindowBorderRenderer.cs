using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBorderRenderer : MonoBehaviour
{
    private GameObject app;
    public SpriteRenderer border;

    bool m_Activate;

    void Awake()
    {
        m_Activate = true;
        app = gameObject;
        border = gameObject.GetComponent<SpriteRenderer>();
        app.transform.parent = border.transform;
    }

    void LateUpdate()
    {
        //Activate the GameObject
        app.SetActive(m_Activate);

        border.drawMode = SpriteDrawMode.Sliced;
        if (app.activeInHierarchy) {
            //app.SpriteRenderer.size = border.size;
        }
        

    }

}
