using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{     //player rb aka gravity
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public ParticleSystem Dust;

    void Start()
    {

    }
    //When you die death animation play
    private void OnCollisionEnter(Collision collision)
    {

    }

    void Update()
    {
        //Player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = (Vector2.up * 30);
            CreateDust();
        }

        void CreateDust()
        {
            Dust.Play();
        }
    }
     
    
}