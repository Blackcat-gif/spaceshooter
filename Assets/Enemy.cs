using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(Vector3.up* speed *Time.deltaTime);
    }
}
