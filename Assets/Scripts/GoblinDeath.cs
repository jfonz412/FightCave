using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinDeath : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            Destroy(gameObject);
        }
    }
}
