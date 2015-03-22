using UnityEngine;
using System.Collections;

public class followScript : MonoBehaviour {
	
	public GameObject toFollow;
	
	private Vector3 offsetPosition;
	// Use this for initialization
	void Start () {
		
		offsetPosition = toFollow.transform.position-transform.position;
	}
	
	void FixedUpdate () {		
		transform.position = toFollow.transform.position - offsetPosition;
	}
}
