using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SensorToolkit;

public class EnemyChasePlayer : MonoBehaviour
{
    public Sensor sensor;
    //public Animator animator;
    public bool active;
    public GameObject origin;

    void Update()
    {
        var detected = sensor.GetNearest();
        if(detected != null)
        {
            Chase(detected);
        }else
        {
            if (active)
            {
                Comeback();
            }
            else
            {
                Idel();
            }           
        }
    }

    void Chase(GameObject target)
    {
        var speed = 2.9f;

        transform.LookAt(target.transform);
        transform.position += transform.forward * speed * Time.deltaTime;

        //animator.SetFloat("Speed_f", speed);

        if((transform.position - target.transform.position).magnitude < 0.5f)
        {
            //Destroy(target);
            Debug.Log("Hecho!");
        }

        active = true;
    }

    void Comeback()
    {
        var speed = 5f;

        transform.LookAt(origin.transform);
        transform.position += transform.forward * speed * Time.deltaTime;

        //animator.SetFloat("Speed_f", speed);

        if ((transform.position - origin.transform.position).magnitude < 0.5f)
        {
            active = false;
        }
    }

    void Idel()
    {
        //animator.SetFloat("Speed_f", 0);
    }
}
