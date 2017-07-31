using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public int speed;

    void Update()
    {
        ControlPlayer();
    }


    void ControlPlayer()
    {
        //will be 1 or -1 depending on input
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); 
        float moveVertical = Input.GetAxisRaw("Vertical");

        //create a location to move to, multiply it by speed and time in seconds
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //move player with time in seconds (as opposed to frames) relative to the world
        transform.Translate(movement * -speed * Time.deltaTime, Space.World); // as opposed to Self

        if (movement != Vector3.zero) //make sure player is moving before rotating
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        }
    }
}