using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlThroughRigidbody : MonoBehaviour {
    Rigidbody rb;
    public float speed = 10;
    float moveX, moveZ;

    void Start() {
        //we are getting access to our gameobject's rigidbody.
        //Of course it must have one!
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate() {
        //rb.velocity = new Vector3(moveX * speed, 0, moveZ * speed);
        //note: minimizing the y value will slow down gravity!! It's ok for environments 
		  //with zero gravity. Otherwise we need to assign the current velocity value to y
        rb.velocity = new Vector3(moveX * speed, rb.velocity.y, moveZ*speed);
    }
}
