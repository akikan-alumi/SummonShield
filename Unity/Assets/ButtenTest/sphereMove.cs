using UnityEngine;
using System.Collections;

public class sphereMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = new Vector3 (1,0,0);
	}
}
