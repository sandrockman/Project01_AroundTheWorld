/*@author Michael Dobson
 * Script_Planets creates rotations and orbits for individual planets
 */
using UnityEngine;
using System.Collections;

public class Script_Planets : MonoBehaviour {

	[Tooltip("The speed that this object will rotate on it's axis")]
    public float rotationSpeed = 2;
	[Tooltip("The speed that this object will orbit")]
    public float orbitSpeed = .5F;
	[Tooltip("The object that this object will be orbiting around")]
    public GameObject rotationBase;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		Orbit ();
		Rotate ();
	}

	void Orbit ()
	{
		//orbits the planet around whatever it needs to orbit around
		transform.RotateAround(rotationBase.transform.position, Vector3.down, orbitSpeed * Time.deltaTime);
	}

	void Rotate ()
	{
		//Rotates the planet on its axis
		transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
