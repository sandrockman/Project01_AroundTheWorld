using UnityEngine;
using System.Collections;

public class Script_Planets : MonoBehaviour {

    public float rotationSpeed = 2;
    public float orbitSpeed = .5F;
    public GameObject rotationBase;
    public string orbitBaseTag;

	// Use this for initialization
	void Start () {
        rotationBase = GameObject.FindGameObjectWithTag(orbitBaseTag);
	}
	
	// Update is called once per frame
	void Update () {
        rotationBase = GameObject.FindGameObjectWithTag(orbitBaseTag);
        transform.RotateAround(rotationBase.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
