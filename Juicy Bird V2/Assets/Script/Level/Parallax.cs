using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed = 15f;
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;

    void Update()
    {
        background1.transform.position -= background1.transform.right * Time.deltaTime * speed * 1;
        background2.transform.position -= background2.transform.right * Time.deltaTime * speed * 1.3f;
        background3.transform.position -= background3.transform.right * Time.deltaTime * speed * 1.5f;
        background4.transform.position -= background4.transform.right * Time.deltaTime * speed * 1.7f;
    }
}
