using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Transform target;
	NavMeshAgent myAgent;

	// Use this for initialization
	void Start () {
		// from the start the enemy get the player as the Agent
		// its being done at the start to avoid doing it on every frame
		myAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(myAgent.remainingDistance);

		myAgent.destination = target.position;
		if(myAgent.remainingDistance <= myAgent.stoppingDistance && myAgent.remainingDistance != 0)
		{
			Application.LoadLevel (Application.loadedLevelName);
		}
	
	}
}
