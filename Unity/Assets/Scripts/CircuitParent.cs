using UnityEngine;
using System.Collections;

public class CircuitParent : MonoBehaviour {
	
	//このオブジェクトのSpriteRendererコンポーネント
	protected SpriteRenderer spRenderer;
	//この回路オブジェクトより下の階層にある全てのSpriteRendererコンポーネント
	protected SpriteRenderer[] childSpRenderer;

	//敵と触れているフラグ--------------------------------------------------------------
	private bool enemyHitFlag = false;	
	// Use this for initialization
	void Awake() {
		
		//このオブジェクトのSpriteRendererを取得
		spRenderer = GetComponent<SpriteRenderer> ();
		
		//この回路オブジェクトより下の階層にある全てのSpriteRendererコンポーネントを取得
		childSpRenderer = GetComponentsInChildren <SpriteRenderer>();
	}

	//エネミーと接触している間実行される　描画OFF処理
	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.CompareTag ("Enemy")) {
			foreach(SpriteRenderer s in childSpRenderer){
				//回路の描画をOFFにする
				s.enabled = false;
			} 
		}
	}
	
	//エネミーと接触しなくなった時に実行される 描画ON処理
	void OnTriggerExit2D(Collider2D col){

		if (col.gameObject.CompareTag ("Enemy") ) {
			//回路の描画再開
			foreach(SpriteRenderer spr in childSpRenderer){
				spr.enabled = true;
				Debug.Log("In OnTriggerEnter2D");

			}
		}
	}

	/// <summary>
	/// エネミー側で回路描画をオンにするメソッド
	/// </summary>
	/// <param name="enabledSwitch">スイッチ<c>true</c>回路描画</param>
	public void EnabledSwitch(bool enabledSwitch){
		if(enabledSwitch){
			foreach(SpriteRenderer spr in childSpRenderer){
				spr.enabled = true;
			}
		}
	}
}
