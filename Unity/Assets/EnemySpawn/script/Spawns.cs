using UnityEngine;
using System.Collections;

public class Spawns : MonoBehaviour {
	[SerializeField]
	 private int count = 0;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		if (count != 0)
						count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if( count >= 60 ) {
			count=0;
			Instantiate(prefab,this.transform.position,this.transform.rotation);
		}
	}
}
