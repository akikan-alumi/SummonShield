using UnityEngine;
using System.Collections;

public class WallSlope : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		transform.LookAt(target);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
