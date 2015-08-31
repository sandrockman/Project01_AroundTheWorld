/* @author Victor Haskins
 * Script_Ship.cs simple instructions for ship movement with slowly incrementing speed and time.
 */
using UnityEngine;
using System.Collections;

public class Script_Ship : MonoBehaviour {
	//Inspector (public) variables
	public float moveSpeed = 4.0f;
	public float rotateSpeed = 50.0f;
	public float speedIncreaseAmount = 0.007f;
	//point information was initially created for proof of concept
		//public float pointIncreaseAmount = 1f;
		//public float points = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Get the rotation of the player.
		float newRotate = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime ;
		//Rotate the player.
		transform.Rotate (Vector3.up * newRotate);

		//Get the movement of the player.
		transform.localPosition += transform.forward * moveSpeed * Time.deltaTime;
		Runaway ();
	}

	// Increases the speed and point values by specified amounts
	// Point value increase simply proof of concept
	void Runaway() {
		moveSpeed += speedIncreaseAmount;
		//points += pointIncreaseAmount;
	}


}
