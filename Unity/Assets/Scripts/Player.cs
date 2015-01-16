using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
<<<<<<< HEAD

	 初期化
	void Start () {
=======
	private bool gameOver; //ゲームオーバーフラグ
	[SerializeField]
	private GameObject gameOverObj;
	private Result finish;

	// 初期化
	void Start () {
		 finish = gameOverObj.GetComponent<Result>();
/>>>>>> origin/Score
	}
	
	// 毎フレームごとに更新
	void Update () {
	
	}

<<<<<<< HEAD
	void OnTriggerEnter2D(Collider2D col){ // 衝突判定
		if (col.gameObject.CompareTag("Enemy")) { // Enemyに当たったらゲームオーバーフラグをTrueに
			Destroy(col.gameObject);
			Debug.Log("PlayerHit");
//=======
	void OnTriggerEnter2D (Collider2D col){
	if (col.gameObject.CompareTag("Enemy")) { // Enemyに当たったらゲームオーバーフラグをTrueに
			finish.GameOver();
>>>>>>> origin/Score
		}
	}
}
