using UnityEngine;
using System.Collections;

public class TrueGravityAttractor : MonoBehaviour {

	public float masse;

	public Vector3 Attract(TrueGravityBody gravityBody){
		//print ("applyGravityForce");
		
		Vector3 affectedXYZ = gravityBody.transform.position;

		Vector3 affectingXYZ = this.transform.position;
		

		float distance = (affectingXYZ - affectedXYZ).magnitude;
		Vector3 direction = (affectingXYZ- affectedXYZ ).normalized;

		float force = (gravityBody.masse*this.masse)/Mathf.Pow(distance,2);
		Vector3 vecteurForce = force * direction;
		gravityBody.GetComponent<Rigidbody>().AddForce(vecteurForce);


		Debug.DrawLine(gravityBody.transform.position, gravityBody.transform.position+direction*10, Color.red,120);


		return affectingXYZ- affectedXYZ ;
		/*
		print ("------------");
		
		print (this.name);
		print (" affectedXYZ : "+affectedXYZ);
		print (" affectingXYZ : "+affectingXYZ);
		print (" distance : "+distance);
		print (" direction : "+direction);
		print (" force : "+force);
		print (" vecteurForce : "+vecteurForce);
		print ("------------");*/

	}
}
