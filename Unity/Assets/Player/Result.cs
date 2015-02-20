using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {
	
	// 初期値セット
	private float score = 0f;
	private float tempScore = 0f;
	private float dateTime = 0f;
	[SerializeField] 
	private GameObject resultView;
	[SerializeField]
	private GameObject scoreTextObj;
	[SerializeField]
	private GameObject canvas;
	[SerializeField]
	private GameObject nowScoreTextObj;
    public GameObject conTextObj;
	private Text nowScoreText;
	private Text scoreText;
    private Text conText;
	[SerializeField]
	private float addSpeed = 0.125f;
	public GameObject[] spawners;
	private bool gameOver;
	private string strScore;
	private static float highScore;
	private ClickPositionCreatePrefabScript stopFlg;
	[SerializeField]
	private GameObject ClickObj;
	public float[] levelLine = {1000,2000,3000,4000,5000,6000,7000};
	private int level = 0;
	//private int enemySu;
	private Spawns spawns;
	public GameObject spawnsObj;
	private GameObject[] circuits;
    private bool Congratulations = false;
    private int end;

	void Start ()
	{
		spawns = spawnsObj.GetComponent<Spawns> ();
		highScore = PlayerPrefs.GetFloat ("highScore");
		//enemySu = spawns.sentEnemy;
		stopFlg = ClickObj.GetComponent<ClickPositionCreatePrefabScript> ();
		scoreText = scoreTextObj.GetComponent<Text> ();
		nowScoreText = nowScoreTextObj.GetComponent<Text> ();
		gameOver = false;
		spawners = GameObject.FindGameObjectsWithTag("Spawner");
		circuits = GameObject.FindGameObjectsWithTag("Circuit");
        conText = conTextObj.GetComponent<Text>();
		
	}
	
	void Update ()
	{
		if(gameOver == false){
			dateTime += Time.deltaTime;
			tempScore = dateTime;
			score = tempScore * addSpeed; 
			strScore = score.ToString("F0");
			nowScoreText.text = "" + strScore;
			if(score >= levelLine[level] ){
				change();
				Debug.Log ("level"+level);
			}
			//Debug.Log (dateTime);
		}
	}
	
	public void GameOver()
	{
		gameOver = true;
		foreach (GameObject spa in spawners) {
			Destroy(spa);
		}
		foreach (GameObject cir in circuits) {
			Destroy(cir);
		}
		canvas.SetActive (false);
		resultView.SetActive (true);

		stopFlg.sentFlg = 1;
		Time.timeScale = 0;
		scoreText.text = "score:" + strScore;
        conText.text = "Congratulations!!";
        if (score >= levelLine[levelLine.Length - 2] ) {//levelLine[levelLine.Length-2]は6000
            conTextObj.SetActive(true);
        } else {
            conTextObj.SetActive(false);
        }
		if((highScore < score) || (highScore == null)){
			highScore = score;
			PlayerPrefs.SetFloat("highScore",highScore);
			
		}
	}

	void change(){
			Debug.Log ("Congratulations + 現在のlevel" + level);
			if (level < spawns.enemy.Length -1) {
					level++;
			} else {
					//		level = 0;
			}
	}
	public void congratulations () {//全クリしたら spawns.enemy.Length は6
            Congratulations = true;
            GameOver();
            Debug.Log("Congratulations + 現在のlevel"+level);     
	}

	public void setEnd (){
		this.end++;
        //Debug.LogError("えんｄ"+end);
	}
	
	public int getSentLevel(){
        return level;
	}

	
}