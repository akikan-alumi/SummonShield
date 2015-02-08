using UnityEngine;
using System.Collections;

public class CircuitParent : MonoBehaviour {

	//このオブジェクトのSpriteRenderer
	protected SpriteRenderer spRenderer;

	//この回路オブジェクトより下の階層にある全てのSpriteRendererコンポーネント
	protected SpriteRenderer[] childSpRenderer;

	//画像のα値
	protected float alpha = 1;

	protected float fadeInSpeed = 4.0f;
	protected float fadeOutSpeed = 10.0f;

	void Awake() {

		//このオブジェクトのSpriteRendererを取得
		spRenderer = GetComponent<SpriteRenderer> ();
		//この回路に対応した光オブジェクトを取得
		//childFlash = gameObject.transform.Find("CircuitLight");

		//この回路に対応した光オブジェクトのSpriteRendererコンポーネントを取得
		//flash = childFlash.GetComponent<SpriteRenderer>();

		//この回路オブジェクトより下の階層にある全てのSpriteRendererコンポーネントを取得
		childSpRenderer = GetComponentsInChildren <SpriteRenderer>();
	}

	void Update(){
		FadeIn ();
		ChangeTransparency (alpha);
	}

	protected void FadeIn(){
		alpha += Time.deltaTime * fadeInSpeed;
		if(alpha >= 1)alpha = 1;
	}

	protected void ChangeTransparency (float alpha) 
	{
		//回路を徐々に透過する
		this.spRenderer.color = new Color(1, 1, 1, alpha);

		//青い光も合わせて透過する
		//flash.color = new Color(1, 1, 1, alpha);
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.CompareTag ("Enemy")){
			//α値を徐々に下げる
			alpha -= Time.deltaTime * fadeOutSpeed;
			if(alpha < 0)alpha = 0;
		}
	}
}
