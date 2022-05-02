using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tank : Basecontroller
{
    public float speed = 10f;
    public float rotatespeed = 5f;
    public float movespeed = 5f;

    private void OnEnable()
    {
        Custominputmanager.AButton += Fire;
        Custominputmanager.HorizontalAxis += MoveTankHorizontal;
        Custominputmanager.VerticalAxis += MoveTankVertical;
    }

    private void OnDisable()
    {
        Custominputmanager.AButton -= Fire;
        Custominputmanager.HorizontalAxis -= MoveTankHorizontal;
        Custominputmanager.VerticalAxis -= MoveTankVertical;
    }

    private void Update()
    {
        GetmousePosition();
    }


    private void MoveTankHorizontal(float axisValue)
    {
       transform.Rotate(0,axisValue* rotatespeed,0);
    }

    private void MoveTankVertical(float axisValue)
    {
        transform.Translate(new Vector3(0,0,axisValue * movespeed));
    }

    private void GetmousePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray,out hit))
        {
            Vector3 direction = new Vector3(hit.point.x, HeadtTransform.position.y, hit.point.z);
            HeadtTransform.LookAt(direction);
        }
    }

    
}
