using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float distance = 10;
    private float sensitivity = 3f;
    private void OnMouseDrag()
    {

        //Translate
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = objectPos;
        
        //Rotate
        
        float rotX = Input.GetAxis("Mouse X") * sensitivity * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * sensitivity * Mathf.Deg2Rad;

        transform.RotateAround(transform.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
         
    }
}
