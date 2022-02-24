using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tank : Basecontroller
{
    public float speed = 1f;
    public float rotatespeed = 50f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f,0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f,  -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, rotatespeed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -rotatespeed * Time.deltaTime, 0f);
        }
        GetmousePosition();
    }


    private void MoveTank()
    {
        
    }

    private void GetmousePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit))
        {
            HeadtTransform.LookAt(hit.point);
        }
    }

}
