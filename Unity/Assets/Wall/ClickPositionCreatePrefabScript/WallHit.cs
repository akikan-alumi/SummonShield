using UnityEngine;
using System.Collections;

public class WallHit : MonoBehaviour {

	public GameObject Prefab;

	// Use this for initialization
	private void Start () {
	}
	
	// Update is called once per frame
	//絵によってはOnCollisionEnter2D(Collision2D col)に変更の恐れあり
	private void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.CompareTag ("Player")) {
			Destroy (Prefab);
		}

	}
}
