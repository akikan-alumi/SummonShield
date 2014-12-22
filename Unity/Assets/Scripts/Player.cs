using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private bool gameOver; //ゲームオーバーフラグ

	// 初期化
	void Start () {
		gameOver = false; //ゲームオーバーフラグを初期化
	}
	
	// 毎フレームごとに更新
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){ // 衝突判定
		if (col.gameObject.tag == "Enemy") { // Enemyに当たったらゲームオーバーフラグをTrueに
			gameOver = true;
		}
	}
}
