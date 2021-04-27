using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour
{

    public float deadZoneMaxDistance = 0;

    private Vector2 mousePosition;
    private Vector2 startMousePosition;
    private Vector2 startDistance;

    private bool isPresed = false;

    private Vector2 distanceTraveled;
    private Vector2 unholdBottomPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        unholdBottomPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        distanceTraveled = unholdBottomPosition - startDistance;

        if (isPresed == true && distanceTraveled.magnitude > deadZoneMaxDistance)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log(distanceTraveled.magnitude);
            this.gameObject.transform.position = new Vector2(mousePosition.x - startMousePosition.x, mousePosition.y - startMousePosition.y);
        }
    }

    private void OnMouseDown()
    {
        HoldToMove();

    }

    private void OnMouseUp()
    {
        isPresed = false;

    }

    void HoldToMove()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            startMousePosition.x = mousePosition.x - this.transform.localPosition.x;
            startMousePosition.y = mousePosition.y - this.transform.localPosition.y;

            startDistance = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;

            isPresed = true;
        }
    }
}
