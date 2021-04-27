using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SensorToolkit;

public class EnemyChasePlayer : MonoBehaviour
{
    public Sensor sensor;
    //public Animator animator;

    void Update()
    {
        var detected = sensor.GetNearest();
        if(detected != null)
        {
            Chase(detected);
        }else
        {
            Idel();
        }
    }

    void Chase(GameObject target)
    {
        var speed = 3f;

        transform.LookAt(target.transform);
        transform.position += transform.forward * speed * Time.deltaTime;

        //animator.SetFloat("Speed_f", speed);

        if((transform.position - target.transform.position).magnitude < 0.5f)
        {
            //Destroy(target);
            Debug.Log("Hecho!");
        }
    }

    void Idel()
    {
        //animator.SetFloat("Speed_f", 0);
    }
}
