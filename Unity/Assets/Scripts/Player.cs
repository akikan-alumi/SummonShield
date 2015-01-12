using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// 初期化
	void Start () {
	}
	
	// 毎フレームごとに更新
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){ // 衝突判定
		if (col.gameObject.CompareTag("Enemy")) { // Enemyに当たったらゲームオーバーフラグをTrueに
			Destroy(col.gameObject);
			Debug.Log("PlayerHit");
		}
	}
}
