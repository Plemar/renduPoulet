using UnityEngine;
using System.Collections;

public class gravityObject : MonoBehaviour {

	public float masse;

	private Transform myTransform;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody>().useGravity = false;
		myTransform = transform;
	}
}
