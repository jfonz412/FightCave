using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    private Health health;

    void Start()
    {
        health = GetComponent<Health>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Taking damage!");
            health.TakeDamage(1);
        }
    }
}
