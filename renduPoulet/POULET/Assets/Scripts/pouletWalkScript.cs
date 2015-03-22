using UnityEngine;
using System.Collections;

public class pouletWalkScript : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.RightArrow)) {
			animator.SetInteger("transitionPoulet", 1);
		}
		if (Input.GetKeyUp(KeyCode.DownArrow)&&Input.GetKeyUp(KeyCode.UpArrow)&&Input.GetKeyUp(KeyCode.LeftArrow)&&Input.GetKeyUp(KeyCode.RightArrow)) {
			animator.SetInteger("transitionPoulet", 0);
		}
	}

}
