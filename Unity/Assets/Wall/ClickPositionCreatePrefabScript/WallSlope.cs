using UnityEngine;
using System.Collections;

public class WallSlope : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		transform.LookAt(target);
        this.transform.eulerAngles = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
