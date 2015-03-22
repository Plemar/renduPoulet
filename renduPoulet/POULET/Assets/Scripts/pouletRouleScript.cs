using UnityEngine;
using System.Collections;

public class pouletRouleScript : MonoBehaviour {


	public GameObject poulet,cage;
	private Vector3 offsetPositionPoulet;
	public float speed;
	// Use this for initialization
	void Start () {
		offsetPositionPoulet = cage.transform.position-poulet.transform.position;
	}
	void Update(){
		poulet.transform.position = cage.transform.position - offsetPositionPoulet;
		poulet.transform.Rotate (0, cage.transform.rotation.y, 0);
	}
	// Update is called once per frame
	void FixedUpdate () {
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
		cage.GetComponent<Rigidbody>().AddForce (movement*speed*Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			Vector3 jump = new Vector3(0.0f,500f,0.0f);			
			cage.GetComponent<Rigidbody>().AddForce (jump);
			
		}
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			
			cage.GetComponent<Rigidbody>().velocity=Vector3.zero;
			cage.GetComponent<Rigidbody>().angularVelocity=Vector3.zero;
			
		}


	}
}
