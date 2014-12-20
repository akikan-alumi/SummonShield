using UnityEngine;
using System.Collections;

public class TitlePlayer : MonoBehaviour {
	private bool TitleSummon; //サモン（タイトル）フラグ生成
	
	// 初期化
	void Start () {
		TitleSummon = false; //サモン（タイトル）フラグを初期化
	}
	
	// 毎フレームごとに更新
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collision2D col){ // 衝突判定
		if (col.gameObject.tag == "TitleEnemy") { // TitleEnemyに当たったらサモン（タイトル）フラグをTrueに
			TitleSummon = true;
		}
	}
}
