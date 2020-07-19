using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;                  //initialising your variable 
    private float turnSpeed = 25f;
    private float horizontalInput;

    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");  
        //can understand input from a variety of gadgets like a mouse or controller

        //we'll move our vehicle in this function
        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime* speed* forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed* horizontalInput); to shift left and right but with no rotation
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); //shift left and right but with rotation
        


    }
}
