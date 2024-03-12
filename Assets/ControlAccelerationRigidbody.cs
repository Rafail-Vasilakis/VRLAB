using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAccelerationRigidbody : MonoBehaviour {
    Rigidbody rb;
    public float acc = 30; //this is acceleration, not speed!
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
        //The speed is increased / decreased based on the input buttons
        //Note that we need deltaTime again, to maintain the same increase accross different framerates
        rb.velocity += new Vector3(moveX * acc * Time.deltaTime, 0,
            moveZ * acc * Time.deltaTime);

        //the body may accelerate quickly and it will be difficult to control.
        //try increasing the 'drag' value in rigidbody or adding rigidbody material with friction
    }
}
