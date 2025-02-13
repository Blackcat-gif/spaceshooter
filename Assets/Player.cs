using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int speed ;
    private Vector3 movement;
    private float horizontalInput;
    private float verticalInput;

    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private GameObject lasersContainer;

    private float firingRate = 0.2f;
    private float canIFire = -1f;
    // Update is called once per frame
    void Start()
    {
        transform.position = Vector3.zero;
    }
    void Update()
    {
        PlayerMovement();
    }
    void ShootingLaser()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > canIFire)
        {
            Instantiate(laserPrefab, transform.position + new Vector3(0, 0.8f, 0), Quarternion.identity, lasersContainer.transform);
        }
    }
    void PlayerMovement()
    {
        horizontalinput = Input.GetAxisRaw("Horizontal");
        verticalinput = Input.GetAxisRaw("Vertical");
        movement = new Vector3(horizontalinput, verticalinput, 0);
        transform.Translate(movement * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 3.8f, 0), 0);
        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }
    }  
}
