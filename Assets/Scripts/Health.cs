using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int hp;// { get; set; }

	// Update is called once per frame
	void Update () {
		if(hp <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void TakeDamage(int damage)
    {
        hp = hp - damage;
    }
}
