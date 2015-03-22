using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float movespeed =5;
	private Vector3 moveDirection ;
	private Rigidbody rigidbody;
	void Start(){
		rigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		moveDirection = new Vector3 (Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Jump"),Input.GetAxisRaw("Vertical")).normalized;
	}

	void FixedUpdate(){
		//rigidbody.MovePosition (rigidbody.position+ transform.TransformDirection(moveDirection)*movespeed*Time.deltaTime);
		rigidbody.AddForce (moveDirection * movespeed );
	}
}
