using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
	public GameObject Enemy;
	// Use this for initialization

	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "Player")
		{
			Destroy(Enemy);
		}
	}
}
