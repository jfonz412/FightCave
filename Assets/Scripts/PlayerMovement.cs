using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //VARIABLES
    public float speed;

    private Rigidbody rb;
    private Transform tf;
    private Vector3 notSpinning;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        notSpinning = tf.eulerAngles; 
    }

    void FixedUpdate()
    {
        Move();
        checkSpin();
    }

    //FUNCTIONS
    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");// * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical");// * Time.deltaTime;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * -speed);

        //experiment
        rb.AddTorque(transform.up * moveHorizontal * speed, ForceMode.Impulse);
    }

    void checkSpin()
    {
        if (rb.angularVelocity == notSpinning && tf.eulerAngles != notSpinning)
        {
            tf.eulerAngles = notSpinning;
        }
    }
}

