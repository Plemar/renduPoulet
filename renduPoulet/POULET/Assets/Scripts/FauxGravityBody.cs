using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FauxGravityBody : MonoBehaviour {

	//public FauxGravityAttractor attractor;

	public List<FauxGravityAttractor> attractors = new List<FauxGravityAttractor>();


	private Transform myTransform;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody>().useGravity = false;
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i<attractors.Count; i++) {			
			attractors[i].Attract(myTransform);
		}
	}
}
