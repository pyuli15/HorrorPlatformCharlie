using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }

    }
}


    /*public float MouseX;
    public float MouseY;
    public float offsetDistance = 0.25f;

    void Update()
    {
        RaycastHit hitInfo;
        MouseX = Input.mousePosition.x;
        MouseY = Input.mousePosition.y;

        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        transform.position = hitInfo.point + hitInfo.normal * offsetDistance;
    }
    */

