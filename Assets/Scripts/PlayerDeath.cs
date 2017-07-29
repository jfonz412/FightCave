using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    private Health health;

    void Start()
    {
        health = GetComponent<Health>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health.TakeDamage(1);
        }
    }
}
