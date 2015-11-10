﻿using UnityEngine;
using System.Collections;

public class GhostMovement : MonoBehaviour {
    float distanceToPacman;
    public Transform pacMan;
    public Transform ghost;
    public Transform[] points;
    private int destPoint = 0;
    NavMeshAgent ghostAgent;
    // Use this for initialization

    void Start () {
        ghostAgent = GetComponent<NavMeshAgent>();
        ghostAgent.autoBraking = false;

        Patrol();
    }
	
	// Update is called once per frame
	void Update () {
        distanceToPacman = Vector3.Distance(ghost.position, pacMan.position);
        if (distanceToPacman < 7.0f) {
            ghostAgent.destination = pacMan.position;
        }
        else if (ghostAgent.remainingDistance < 0.5f)
        {
            Patrol();
        }


        Debug.Log(distanceToPacman);
            
            }
    void Patrol()
    {
        // Set the agent to go to the currently selected destination.
        ghostAgent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }
}