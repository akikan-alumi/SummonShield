using UnityEngine;
using System.Collections;

public class Efect : MonoBehaviour {

	[SerializeField]
	private GameObject unrock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision) {
				if (collision.gameObject.CompareTag ("Enemy")) {
						Instantiate (unrock, transform.position, transform.rotation);
			}
	}


}
