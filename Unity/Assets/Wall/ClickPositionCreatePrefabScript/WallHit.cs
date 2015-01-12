using UnityEngine;
using System.Collections;

public class WallHit : MonoBehaviour {

	public GameObject Prefab;

	// Use this for initialization
	private void Start () {
	}
	
	// Update is called once per frame
	//絵によってはOnCollisionEnter2D(Collision2D col)に変更の恐れあり
	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.CompareTag ("Player")) {
			Destroy (Prefab);
			Debug.Log ("gurimo");
		}
        if (collision.gameObject.CompareTag("Enemy")) {
            Destroy(Prefab);
            Debug.Log("gurimo");
        }

	}
}
