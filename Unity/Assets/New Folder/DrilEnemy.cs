﻿using UnityEngine;
using System.Collections;

public class DrilEnemy : MonoBehaviour {
    [SerializeField]
    private int Hp = 2;

    public GameObject enemySield;
	//[SerializeField]
	//public GameObject player;
	/*[SerializeField]
	private float speed = 1;
	public GameObject obj;//playerを指定*/
	// Use this for initialization
	void Start () {
		//LookAt2D(obj);
		//Move(obj);
        
	}
	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.CompareTag ("Wall")) {
            Hp--;
			if (Hp < 1) {
				Destroy (this.gameObject);
				Debug.Log ("PlayerHit");
		
			}else if(Hp == 1){
                foreach (Transform t in this.transform) {
                    Destroy(t.gameObject);
                }
			}
		}
	}
	
	// Update is called once per frame
	/*void FixedUpdate () {
		// 
		rigidbody2D.velocity = Vector2.up;
	}
	void Move(GameObject target) {
		// (target.transform.position - transform.position)だけでは
		// 距離によって移動速度が変わる
		//よってnormalizedで一定速度にする
		rigidbody2D.velocity = (target.transform.position - transform.position).normalized * speed;
	}
	
	void LookAt2D(GameObject target) {
		// 指定オブジェクトと回転させるオブジェクトの位置の差分(ベクトル)
		Vector3 pos = target.transform.position - transform.position;
		// ベクトルのX,Yを使い回転角を求める
		float angle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
		Quaternion rotation = new Quaternion();
		// 回転角は右方向が0度なので-90
		rotation.eulerAngles = new Vector3(0, 0, angle - 90);
		// 回転
		transform.rotation = rotation;
	}*/
}
