using UnityEngine;
using System.Collections;

public class Revolution : MonoBehaviour {

	public int speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = transform.right.normalized * speed;
	}
}
