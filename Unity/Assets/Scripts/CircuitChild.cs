using UnityEngine;
using System.Collections;

public class CircuitChild : CircuitParent {

	//このオブジェクトのSpriteRendererコンポーネント
	//private SpriteRenderer spRenderer;
	//この回路オブジェクトより下の階層にある全てのSpriteRendererコンポーネント
	//private SpriteRenderer[] childSpRenderer;

	//一階層上のオブジェクトのSpriteRendererコンポーネント
	private SpriteRenderer parentSpRenderer;

	private GameObject parent;

	//
	void Awake() {

		parent = transform.parent.gameObject;
		//このオブジェクトのSpriteRendererを取得
		spRenderer = GetComponent<SpriteRenderer> ();

		//一階層上のオブジェクトのSpriteRendererコンポーネントを取得
		parentSpRenderer = parent.GetComponent<SpriteRenderer>();

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
		if (col.gameObject.CompareTag ("Enemy") && parentSpRenderer.enabled) {
			foreach(SpriteRenderer spr in childSpRenderer){
				spr.enabled = true;
			}
		}
	}
}
