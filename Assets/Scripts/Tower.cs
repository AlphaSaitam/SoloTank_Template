using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatesSample
{
    None,
    Fire,
    
}
public class Tower : Basecontroller
{
    public StatesSample state = StatesSample.None;
    public StatesSample nextstate = StatesSample.Fire;
    public bool Detected = true;
    
    public Transform TankTransform;
    public float detectionDistance;
    private bool _isTankDetected;
    private float _timer =2;
    private bool canShoot = true;

    public void Start()
    {
        state = StatesSample.None;
    }

    public void Update()
    {
        _timer = Time.deltaTime;
        
        IsTankDetected();
       
    }
    
    private void IsTankDetected()
    {
        RaycastHit hit;
        
        Vector3 direction = Vector3.Normalize(TankTransform.position - HeadtTransform.position);
        if (Physics.Raycast(HeadtTransform.position,direction,out hit,detectionDistance))
        {
            
            if (hit.collider.gameObject.GetComponentInParent<Tank>() != null)
            { 
                gameObject.transform.LookAt(TankTransform.position);

                if (canShoot == true)
                {
                    StartCoroutine(Firedelay());
                    canShoot = false;
                }
                
            }
        }
    }

    IEnumerator Firedelay()
    {
        Fire();
        yield return new WaitForSeconds(2);
        canShoot = true;
    }
    
}
