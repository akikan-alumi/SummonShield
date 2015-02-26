using UnityEngine;
using System.Collections;

public class BossSpawner : MonoBehaviour {

	public GameObject[] enemy;
	public GameObject ResultObj;
	private int level = 0;
    private Result result;
    void Start() {
        result = ResultObj.GetComponent<Result>();
    }

	void Update(){
		level = result.getSentLevel();
		}
	// ボスをスポーンさせる
	public void bossSpawn () {

		if(GameObject.Find("BossEnemy1(Clone)") == null){ 
        	Instantiate(enemy[level], this.transform.localPosition, this.transform.localRotation);
		}
     }
}