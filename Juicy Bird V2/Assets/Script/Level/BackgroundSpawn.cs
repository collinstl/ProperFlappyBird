using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{
    public GameObject background;
    //public Transform levelGenerator;
    public float spawnDelay = 5.0f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0.0f, spawnDelay); // Calls Spawnobject function which spawns new level piece every few seconds
    }
        void SpawnObject()
    {
        Instantiate(background, new Vector3(100, -3, 0), Quaternion.identity);
    }
}
