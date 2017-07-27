using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzleOut : MonoBehaviour {
    public float startTime { get; set; }

    public void SetTime(float time)
    {
        startTime = time;
    }

	
	// Update is called once per frame
	void Update () {
		if(Time.time >= startTime + 5.0f)
        {
            Destroy(gameObject);
        }
	}
}
