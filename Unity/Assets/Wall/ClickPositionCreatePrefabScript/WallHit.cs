using UnityEngine;
using System.Collections;

public class WallHit : MonoBehaviour {

	public GameObject Prefab;
	[SerializeField]
	private float destroyTime = 5.0f;

	// Use this for initialization
	private void Start () {
		Destroy (this.gameObject,destroyTime);
	}
	
	// Update is called once per frame
	//絵によってはOnCollisionEnter2D(Collision2D col)に変更の恐れあり
	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.CompareTag ("Player")) {
			Destroy (Prefab);
			Debug.Log ("PlayerHit");
		}
        if (collision.gameObject.CompareTag("Enemy")) {
            Destroy(this.gameObject);
			Destroy(collision.gameObject);
            Debug.Log("EnemyHit");
        }

	}
}
