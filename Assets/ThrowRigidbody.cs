using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRigidbody : MonoBehaviour {
    Rigidbody rb;
    public Vector3 fireVelocity = new Vector3(10, 8, 0);

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        //whenever the user presses the fire button
        //the fireVelocity (editable thorugh Unity Editor)
        //is assigned to the rigidbody
        if (Input.GetButtonDown("Fire1"))
            rb.velocity = fireVelocity;

        //can be used as a projectile in Angry Birds-type worlds.
    }
}
