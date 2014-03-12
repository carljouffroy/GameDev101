using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
	public float distanceToSee = 4f;
	RaycastHit whatIHit;
	public bool hasKey = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.blue);
		//"out" will store variables into whatIHit
		if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
		{
			if(Input.GetKeyDown(KeyCode.Keypad0))
			{
				if(whatIHit.collider.name == "Exit")
				{
					//you can also check for false in hasKey using !
					if(hasKey)
					{
						whatIHit.collider.gameObject.GetComponent<Animator>().SetTrigger("doorOpener");
						hasKey = false;
						Debug.Log("You are Free");
					}
					else
					{
						Debug.Log ("Dam that " +whatIHit.collider.name + " is close you need a key");
					}
				}
				if(whatIHit.collider.name == "Key")
				{
					Debug.Log ("1" +whatIHit.collider.name + " collected");
					hasKey = true;
					Destroy(whatIHit.collider.gameObject);
				}
			}
		}
	}
}



