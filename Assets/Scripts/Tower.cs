using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Basecontroller
{
    public Transform TankTransform;
    public float detectionDistance;
    private bool _isTankDetected;
    public float timeBeforeFire;
    private float _timer =2;
    private bool canShoot = true;

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
                //Fire();
                Debug.DrawRay(HeadtTransform.position,direction,Color.red,1f);
                Debug.Log("j'ai détecter ma cible");
                
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
    

    private void FireTimer()
    {
        
    }
}
