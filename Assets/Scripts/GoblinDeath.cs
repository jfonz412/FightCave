using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinDeath : MonoBehaviour {
    private Health health;


    void Start()
    {
        health = GetComponent<Health>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            health.TakeDamage(1);
        }
    }
}
