using UnityEngine;
using System.Collections;


public class Spawns : MonoBehaviour {

	private int count = 0;
	[SerializeField]
	private int spawnSpace = 60;
	[SerializeField]
	private GameObject prefab;
	[SerializeField]
	private int startTime = 0;
	private float nowTime = 0f;

	// Update is called once per frame
	void Update () {
		count++;
		nowTime += Time.deltaTime;

		//スポーン間隔を満たしたら && 一時停止状態じゃないときスポーンする
		if (count >= spawnSpace && Time.timeScale != 0 && nowTime >= (float)startTime) {
						
			count = 0;
						
			Instantiate (prefab, this.transform.position, this.transform.rotation);
				
		} else if(Time.timeScale != 1){
			count = 0;	
		}
	}
}