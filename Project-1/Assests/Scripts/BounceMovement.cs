/**
 * Author: Mandresh Sundararajan
 * Created: 08/29/2022
 * Brief: This code helps the bounce ball to move around the play area. 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 0.5f;
    [SerializeField] float jumpForce = 2f;
    [SerializeField] AudioSource jumpSound;

    void Start()
    {
        Debug.Log("Bounce Game: Start");
        rb = GetComponent<Rigidbody>();
        jumpSound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput= Input.GetAxis("Horizontal");
        float verticalInput= Input.GetAxis("Vertical");

        rb.velocity= new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if(Input.GetButtonDown("Jump")) //jump
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            jumpSound.Play();
        }
    }
}
