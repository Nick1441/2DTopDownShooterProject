using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyPathFinder : MonoBehaviour {


    public Transform target;
    private IAstarAI ai;

    //Setting components up.
	private void Start ()
    {
        ai = GetComponent<IAstarAI>();
	}
    
    //Updates enemies destination to the player every second.
    private void FixedUpdate ()
    {
		if (target != null && ai != null)
        {
            ai.destination = target.position;
            ai.SearchPath();
        }
	}

    //Setting target for enemies to follow.
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
