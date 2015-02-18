using UnityEngine;
using System.Collections;

public class BossSpawner : MonoBehaviour {

	private int count = 0;
	[SerializeField]
	private int spawnSpace = 60;
	[SerializeField]
	private GameObject[] enemy;
	[SerializeField]
	private int startTime = 0;
	private float nowTime = 0f;

    //ボスが出るかどうかの変数
    private int BossRand;
    private Result result;
    void Start() {
        BossRand = Random.Range(0, 2);//0~1の範囲は0,2でランダムで選ばれる
        result = GetComponent<Result>();
    }
	// Update is called once per frame
	void Update () {
		count++;
		nowTime += Time.deltaTime;

        //スポーン間隔を満たしたら && 一時停止状態じゃないときスポーンする
        
            if (count >= spawnSpace && Time.timeScale != 0 && nowTime >= (float)startTime && result.getSentLevel() != 3) {
                if (BossRand == 1 || result.getSentLevel() == result.spawners.Length) {
                    count = 0;

                    Instantiate(enemy[0], this.transform.position, this.transform.rotation);
                }
                BossRand = Random.Range(0, 2);
            }
            else if (Time.timeScale != 1) {
                count = 0;
                BossRand = Random.Range(0, 2);
            }
        }
	
}