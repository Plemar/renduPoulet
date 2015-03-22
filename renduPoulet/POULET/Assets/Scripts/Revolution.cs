using UnityEngine;
using System.Collections;

public class Revolution : MonoBehaviour {


	public GameObject orbitTrajectory;
	public Vector3 axisOfRevolution;
	public float revolutionSpeed;

	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = orbitTrajectory.transform.position;
		transform.Rotate(axisOfRevolution,  revolutionSpeed * Time.deltaTime,Space.World); // rotation revolution

		
		
	}
}
