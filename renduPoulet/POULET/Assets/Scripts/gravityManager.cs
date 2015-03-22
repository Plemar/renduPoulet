using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gravityManager : MonoBehaviour {

	public List<gravityObject> gObjects = new List<gravityObject>();
	public float gravityConstant;

	public void manageGravity(){

		foreach( gravityObject gObject in gObjects){
			//print ("manageGravity :" + gObject.name);
			foreach( gravityObject gObjectbis in gObjects){
				if(gObject!=gObjectbis){
					applyGravityForce(gObject,gObjectbis);
				}
			}
		}
	}

	public void applyGravityForce(gravityObject affected, gravityObject affecting){
		//print ("applyGravityForce");

		Vector3 affectedXYZ = affected.transform.position;
		Vector3 affectingXYZ = affecting.transform.position;
		float distance = (affectedXYZ - affectingXYZ).magnitude;
		Vector3 direction = (affectingXYZ- affectedXYZ ).normalized;

		float force = (affected.masse*affecting.masse*gravityConstant)/Mathf.Pow(distance,2);
		//print ("force : "+force);
		affected.GetComponent<Rigidbody>().AddForce (force * direction);
	}

	public void FixedUpdate(){
		//print ("FixedUpdate");
		manageGravity ();
	}
	
}
