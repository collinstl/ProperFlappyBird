using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBackground : MonoBehaviour
{
    public float destroySpeed = 10.0f;
    
    void Update()
    {
        Destroy(gameObject, destroySpeed);
    }
}
