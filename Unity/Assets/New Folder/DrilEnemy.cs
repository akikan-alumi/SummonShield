using UnityEngine;
using System.Collections;

public class DrilEnemy : MonoBehaviour {
	[SerializeField]
	private int Hp = 1;

	// Use this for initialization
	void Start () {


	}
	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.CompareTag ("Wall")) {
			if (Hp <= 1) {
				Destroy (this.gameObject);
				Destroy(collision.gameObject);
				Debug.Log ("PlayerHit");
		
			}else{
				Hp--;
				Destroy(collision.gameObject);
			}
		}else if (collision.gameObject.CompareTag ("Player")) {
			Destroy(this.gameObject);		
		}
	}

}
