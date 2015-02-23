using UnityEngine;
using System.Collections;

public class BossSpawner : MonoBehaviour {

	//private int count = 0;
	//[SerializeField]
	//private int spawnSpace = 60;
	public GameObject[] enemy;
	//[SerializeField]
	//private int startTime = 0;
	//private float nowTime = 0f;
	public GameObject ResultObj;
	private int level = 0;
    //ボスが出るかどうかの変数
    private int BossRand;
    private Result result;
    void Start() {
		//BossRand = 1;//Random.Range(0, 2);//0~1の範囲は0,2でランダムで選ばれる
        result = ResultObj.GetComponent<Result>();
    }
	// Update is called once per frame
	public void bossSpawn () {
		//count++;
		//nowTime += Time.deltaTime;

        //スポーン間隔を満たしたら && 一時停止状態じゃないときスポーンする
        
		//if (count >= spawnSpace && Time.timeScale != 0 && nowTime >= (float)startTime && result.getSentLevel() != 4 && GameObject.Find("BossEnemy1(Clone)") == null ) {
        //        if (BossRand == 1 || result.getSentLevel() == result.spawners.Length-1) {
        //            count = 0;
		if(GameObject.Find("BossEnemy1(Clone)") == null){ 
        	Instantiate(enemy[level], this.transform.position, this.transform.rotation);
		}
		//        }
        //        BossRand = Random.Range(0, 2);
        //    }
        //    else if (Time.timeScale != 1) {
        //        count = 0;
        //        BossRand = Random.Range(0, 2);
        //    }
     }
	
}