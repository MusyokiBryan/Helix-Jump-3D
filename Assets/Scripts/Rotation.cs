using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 50;
    void Update()
    {
        if(!GameManager.isGameStarted)
        return;
        //for PC
        /*if(Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxisRaw("Mouse X");
            transform.Rotate(0, -mouseX * rotationSpeed * Time.deltaTime, 0);
        }*/

        //Code for Android
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            float xDelata = Input.GetTouch(0).deltaPosition.x;
            transform.Rotate(0, -xDelata * rotationSpeed * Time.deltaTime, 0);
        }
    }
}
