using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int bulletSpeed = 30; //can be setup for each bullet prefab from the inspector
    public int bulletDirection = 1; //negative is right to left

    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletDirection*0.1f*bulletSpeed, 0), ForceMode2D.Impulse);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
