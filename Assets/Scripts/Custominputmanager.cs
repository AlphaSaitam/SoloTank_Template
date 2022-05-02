using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custominputmanager : MonoBehaviour
{
    public delegate void InputButtonController();
    public static event InputButtonController AButton;
    
    public delegate void InputCustomAxis(float axisValue);
    public static event InputCustomAxis HorizontalAxis;
    public static event InputCustomAxis VerticalAxis;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            AButton?.Invoke();
        }

        if (Input.GetAxis("Horizontal") !=0f)
        {
            HorizontalAxis?.Invoke(Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical")!=0f)
        {
            VerticalAxis?.Invoke(Input.GetAxis("Vertical"));
        }
    }
}
