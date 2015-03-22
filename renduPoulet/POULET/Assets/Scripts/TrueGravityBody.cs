using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrueGravityBody : MonoBehaviour {

	//public FauxGravityAttractor attractor;
	
	public List<TrueGravityAttractor> attractors = new List<TrueGravityAttractor>();
	public float masse;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//print("Velocity : "+GetComponent<Rigidbody>().velocity);


		Vector3 closestAttractor=new Vector3();

		for (int i = 0; i<attractors.Count; i++) {
		Vector3 distanceV =
				attractors[i].Attract(this);			
			if(i==0)closestAttractor=distanceV;
			if(distanceV.magnitude<closestAttractor.magnitude)
				closestAttractor=distanceV;
		}

		print(GetComponent<Rigidbody>().velocity);
		Quaternion targetRotation = Quaternion.FromToRotation(transform.up,closestAttractor.normalized)*transform.rotation;
		transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, 50 * Time.deltaTime);
	}
}
