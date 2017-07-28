using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoltCollision : MonoBehaviour {
    //private Collider collider;

    void Start()
    {
        //collider = GetComponent<Collider>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
