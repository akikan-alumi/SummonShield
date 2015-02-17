using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        Destroy(this.gameObject,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
