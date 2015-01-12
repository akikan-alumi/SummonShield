using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private bool gameOver; //ゲームオーバーフラグ
	[SerializeField]
	private GameObject gameOverObj;
	private Result finish;

	// 初期化
	void Start () {
		 finish = gameOverObj.GetComponent<Result>();
	}
	
	// 毎フレームごとに更新
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col){
	if (col.gameObject.CompareTag("Enemy")) { // Enemyに当たったらゲームオーバーフラグをTrueに
			finish.GameOver();
		}
	}
}
