using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Basecontroller
{
    public Transform TankTransform;
    public float detectionDistance;
    private bool _isTankDetected;
    public float timeBeforeFire;
    private float _timer;

    private void IsTankDetected()
    {
        RaycastHit hit;
        Vector3 direction = Vector3.Normalize(TankTransform.position - HeadtTransform.position);
        if (Physics.Raycast(HeadtTransform.position,direction,out hit,detectionDistance))
        {
            if (hit.collider.gameObject.GetComponentInParent<Tank>() != null)
            {
                Debug.DrawRay(HeadtTransform.position,direction,Color.green,1f);
                Debug.Log("j'ai détecter ma cible");
            } 
        }

    }

    private void FireTimer()
    {
        
    }
}
