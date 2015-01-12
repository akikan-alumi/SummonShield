using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	public GameObject player;
	private Vector2 speed = new Vector2( 0f,-10f);
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// 
        rigidbody2D.velocity = Vector2.up;
	}
}
