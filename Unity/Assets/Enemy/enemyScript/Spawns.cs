using UnityEngine;
using System.Collections;


public class Spawns : MonoBehaviour {

	private int count = 0;
	[SerializeField]
	private int spawnSpace = 60;
	[SerializeField]
	private GameObject[] enemy;
	[SerializeField]
	private int startTime = 0;
	private float nowTime = 0f;
	private int level = 0;
	private int enemySu;
	public GameObject ResultObj;
	private Result result;

	void Start(){
		result = ResultObj.GetComponent<Result> ();
		enemySu = enemy.Length;
	}

	// Update is called once per frame
	void Update () {
		count++;
		nowTime += Time.deltaTime;
		level = result.sentLevel;

		//スポーン間隔を満たしたら && 一時停止状態じゃないときスポーンする
		if (count >= spawnSpace && Time.timeScale != 0 && nowTime >= (float)startTime) {
						
			count = 0;
						
			Instantiate (enemy[level], this.transform.position, this.transform.rotation);
			Debug.Log (level);
				
		} else if(Time.timeScale != 1){
			count = 0;	
		}
	}

	
	public void getEnemyObj (int enemySu){
		this.enemySu = enemySu;
	}
	
	public int sentEnemy{
		get{return enemySu;}
		set{ enemySu = value;}
	}
}