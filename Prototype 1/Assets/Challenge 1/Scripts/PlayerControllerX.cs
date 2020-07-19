﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;
    private float forwardInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        forwardInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime* speed* forwardInput);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * verticalInput) ;
        transform.Rotate(Vector3.left, Time.deltaTime * rotationSpeed * verticalInput);
        //transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
    }
}
