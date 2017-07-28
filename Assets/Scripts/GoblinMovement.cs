using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinMovement : MonoBehaviour {
    private Transform[] points = new Transform[3];
    private int destPoint = 0;
    private NavMeshAgent agent;

    void Start()
    {
        points[0] = GameObject.Find("point1").transform;
        points[1] = GameObject.Find("point2").transform;
        points[2] = GameObject.Find("point3").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;//so agent doesn't slow down as it approaches a point
        GoToNextPoint();
    }

    void GoToNextPoint()
    {
        if (points.Length == 0)
            return;
        // set the agent to go to the currently selected destination
        agent.destination = points[destPoint].position;

        //choose the next point or cycle to the start
        destPoint = (destPoint + 1) % points.Length;
    }

    void Update()
    {
        //choose the next destPoint when the agent
        //gets close to the current one
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GoToNextPoint();
    }
}
