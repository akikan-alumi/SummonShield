using UnityEngine;
using System.Collections;

public class RandomStart : MonoBehaviour {
	private float rndStart;
	private float changeTime = 0f;
	private float changeNum = 0f;

	// スタート位置を変更
	void Start () {
		rndStart = Random.Range (0f, 1200f);
		rndPosition ();
	}
	
	// 一定の間隔でワープ
	void Update () {
		rndStart = Random.Range (0f, 1200f);
		changeTime += Time.deltaTime;
		changeNum = Random.Range (3f, 5f);
		if(changeTime >= changeNum){
			rndPosition();
			changeTime = 0f;
		}
	}
	void rndPosition(){
		if ((rndStart >= 0f && rndStart <= 99f ) || (rndStart >= 600f && rndStart <= 699f)) {
			transform.localPosition = new Vector3(4f, 15f, 0f);
		}else if((rndStart >= 100f && rndStart <= 199f) || (rndStart >= 700f && rndStart <= 799f)){
			transform.localPosition = new Vector3(-4f, 15f, 0f);
		}else if((rndStart >= 200f && rndStart <= 299f) || (rndStart <= 800f && rndStart <= 899f)){
			transform.localPosition = new Vector3(12f, 12f, 0f);
		}else if((rndStart >= 300f && rndStart <= 399f) || (rndStart <= 900f && rndStart <= 999f)){
			transform.localPosition = new Vector3(-12f, 12f, 0f);
		}else if((rndStart >= 400f && rndStart <= 499f) || (rndStart <= 1000f && rndStart <= 1099f)){
			transform.localPosition = new Vector3(17f, 4f, 0f);
		}else{
			transform.localPosition = new Vector3(-17f, 4f, 0f);
		}
	}

}