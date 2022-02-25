using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if (other.gameObject.CompareTag("Target"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        
    }
}
