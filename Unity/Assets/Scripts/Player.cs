using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

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

	void OnTriggerEnter2D(Collider2D col){ // 衝突判定
		if (col.gameObject.CompareTag("Enemy")) { // Enemyに当たったらゲームオーバーをTrueに
			Destroy(col.gameObject);
			Debug.Log("PlayerHit");
			finish.GameOver();
		}
	}
}
