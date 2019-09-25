using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour    
{
    AudioSource source;
    [SerializeField]
    AudioClip jumpSound;
    [SerializeField]
    AudioClip deathSound;
    [SerializeField]
    AudioClip boneCrack;
    [SerializeField]
    AudioClip bloodSplash;


    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        source.PlayOneShot(deathSound);
        source.PlayOneShot(boneCrack);
        source.PlayOneShot(bloodSplash);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.PlayOneShot(jumpSound);
        }

    }
}
