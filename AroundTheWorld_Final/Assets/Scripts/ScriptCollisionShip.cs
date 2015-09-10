/* @authors Darrick Hilburn, Victor Haskins
 * ScriptCollisionShip Script used to recognize when a ship collides with
 * a planet and then runs explosion animation, sound and destruction of object.
 */
using UnityEngine;
using System.Collections;

public class ScriptCollisionShip : MonoBehaviour {

	//public (inspector)Variables
	public ParticleSystem explosion;
	public AudioClip explodeSound;
	public float xBoundary = 65;
	public float zBoundary = 100;

	//runs destruction function if ship exceeds boundaries
    void Update()
    {
        if (transform.position.x < -xBoundary  || transform.position.x > xBoundary ||
            transform.position.z < -zBoundary || transform.position.z > zBoundary)
            DestroyShip();
    }

	//runs destruction function if collides with any object
	void OnTriggerEnter(Collider other)
    {
        DestroyShip();
	}

	//Destruction protocol
    void DestroyShip()
    {
		//plays audio clip
		if (explodeSound != null) {
			AudioSource.PlayClipAtPoint (explodeSound, transform.position);
		} else {
			Debug.Log("There is no sound in the explodeSound variable. Please enter one.");
		}
		//plays explosion particle effect
		if (explosion != null) {
			Instantiate (explosion, transform.position, transform.rotation);
		} else {
			Debug.Log("There is no sound in the explodeSound variable. Please enter one.");
		}
		//Destroys game object.
        Destroy(gameObject);
    }
}
