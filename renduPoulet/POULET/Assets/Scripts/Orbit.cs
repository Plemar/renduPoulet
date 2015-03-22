using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {

	
	public GameObject orbitingAround;
	public Vector3 axisOfOrbit;
	public float orbitSpeed;
	
	private float distanceOrbit;
	private Vector3 orbitRadiusVect;
	
	// Use this for initialization
	void Start () {
		orbitRadiusVect = transform.position - orbitingAround.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position =  new Vector3(0, 0, 0); // on ramene a l'origine
		
		transform.Rotate(axisOfOrbit,  orbitSpeed * Time.deltaTime,Space.World); // rotation orbite
		//transform.Rotate(axisOfRevolution,  revolutionSpeed * 10 * Time.deltaTime,Space.World); //rotation sur elle meme
		transform.Translate (orbitRadiusVect, Space.Self); // mise sur orbite autour de l'origine		
		transform.Translate(orbitingAround.transform.position,Space.World);	// translation pour ramener autour de la planete
		
	}
}
