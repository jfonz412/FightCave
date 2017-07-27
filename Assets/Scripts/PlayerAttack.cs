using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    // Require the rocket to be a rigidbody.
    // This way we the user can not assign a prefab without rigidbody
    public Rigidbody capsule;
    public float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBolt();
        }
    }

    void FireBolt()
    {
        Rigidbody capsuleClone = (Rigidbody)Instantiate(capsule, transform.position, transform.rotation);
        capsuleClone.velocity = transform.forward * speed;

        // You can also acccess other components / scripts of the clone
        capsuleClone.GetComponent<FizzleOut>().SetTime(Time.time);
    }
}
