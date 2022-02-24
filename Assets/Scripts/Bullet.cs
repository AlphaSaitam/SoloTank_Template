using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject prefab;
    public float Speedbullet = 100f;
    public GameObject bulletExit;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            GameObject bulletSpawn = Instantiate(prefab,transform.position, Quaternion.identity);
            bulletSpawn.GetComponent<Rigidbody>().AddForce(bulletExit.transform.forward*Speedbullet);
        }
        
    }

    public void OnCollisionEnter(Collision other)
    {
        
    }
}
