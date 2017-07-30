using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoblins : MonoBehaviour {
    public GameObject monster;

    public int amount;
    public float delay;

	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        for(int i = 0; i < amount; i++)
        {
            Instantiate(monster, transform.position, transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
}
