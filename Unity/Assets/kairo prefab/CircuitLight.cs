using UnityEngine;
using System.Collections;

public class CircuitLight : MonoBehaviour {
	
	private SpriteRenderer spRenderer;

	//親を取得
	//private GameObject parent;
	private SpriteRenderer parentSpRenderer;

	void Awake()
	{
		//このスクリプトがアタッチされているオブジェクトのSpriteRendererコンポーネントを取得
		spRenderer = GetComponent<SpriteRenderer> ();

		//parent = transform.parent.gameObject;
		parentSpRenderer = transform.parent.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		Draw ();
	}

	private void Draw()
	{
		this.spRenderer.color = parentSpRenderer.color;
	}
}
