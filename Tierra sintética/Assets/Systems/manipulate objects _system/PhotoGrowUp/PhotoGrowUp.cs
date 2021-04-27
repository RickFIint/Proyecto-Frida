using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoGrowUp : MonoBehaviour
{
    public Animator anim;
    public bool growUp;

    public Canvas canvas;

    public void Grow()
    {
        if (growUp)
        {
            anim.SetTrigger("Decrease");
            growUp = false;
            canvas.overrideSorting = false;
            canvas.sortingOrder = 1;
        }
        else
        {
            anim.SetTrigger("Grow");            
            growUp = true;
            canvas.overrideSorting = true;
            canvas.sortingOrder = 3;
        }
    }
}
