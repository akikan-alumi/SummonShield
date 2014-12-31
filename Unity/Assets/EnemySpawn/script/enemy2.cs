using UnityEngine;
using System.Collections;

public class enemy2 : MonoBehaviour {
	public GameObject player;
	private Vector2 speed =new Vector2( 0f,-1f);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = speed*5f;
	}
}
