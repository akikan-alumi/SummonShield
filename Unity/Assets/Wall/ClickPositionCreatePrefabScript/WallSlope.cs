using UnityEngine;
using System.Collections;

public class WallSlope : MonoBehaviour {
	private Transform target = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
}
