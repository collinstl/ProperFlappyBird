using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroy : MonoBehaviour
{
    public float speed = 10.0f;
    public float destroySpeed = 15.0f;

    void Update()
    {
        transform.position -= transform.right * Time.deltaTime * speed; // Moves the level prefab

        Destroy(gameObject, destroySpeed); // Destroys level prefab after x amount of time
    }
}
