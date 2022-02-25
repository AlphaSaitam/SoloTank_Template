using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Basecontroller : MonoBehaviour
{
    public Transform HeadtTransform;
    public Transform ProjectileSpawnpoint;
    public GameObject ProjectilePrefab;
    protected Vector3 HeadDirection;
    public GameObject prefab;
    public float speedbullet = 100f;


    protected void Fire()
    { 
        GameObject bulletSpawn = Instantiate(prefab, ProjectileSpawnpoint.position, ProjectileSpawnpoint.rotation);
        bulletSpawn.GetComponent<Rigidbody>().AddForce(HeadtTransform.forward*speedbullet);
    }

    
}
