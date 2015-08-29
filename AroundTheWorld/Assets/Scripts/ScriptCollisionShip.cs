using UnityEngine;
using System.Collections;

public class ScriptCollisionShip : MonoBehaviour {

	public ParticleSystem explosion;
	public AudioClip explodeSound;
	//GameObject parentObject = transform.parent;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		AudioSource.PlayClipAtPoint(explodeSound, transform.position);
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
