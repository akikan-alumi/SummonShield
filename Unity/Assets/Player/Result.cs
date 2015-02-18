﻿using UnityEngine;
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
	private Text nowScoreText;
	private Text scoreText;
	[SerializeField]
	private float addSpeed = 0.125f;
	public GameObject[] spawners;
	private bool gameOver;
	private string strScore;
	private static float highScore;
	private ClickPositionCreatePrefabScript stopFlg;
	[SerializeField]
	private GameObject ClickObj;
	private float[] levelLine = {1000,2000,3000,4000,5000};
	private int level = 0;
	private int enemySu;
	private Spawns spawns;
	public GameObject spawnsObj;
	private GameObject[] circuits;

	
	void Awake(){
		spawns = spawnsObj.GetComponent<Spawns> ();
		highScore = PlayerPrefs.GetFloat ("highScore");
	}	

	void Start ()
	{
		enemySu = spawns.sentEnemy;
		stopFlg = ClickObj.GetComponent<ClickPositionCreatePrefabScript> ();
		scoreText = scoreTextObj.GetComponent<Text> ();
		nowScoreText = nowScoreTextObj.GetComponent<Text> ();
		gameOver = false;
		spawners = GameObject.FindGameObjectsWithTag("Spawner");
		circuits = GameObject.FindGameObjectsWithTag("Circuit");
		
		
	}
	
	void Update ()
	{
		if(gameOver == false){
			dateTime += Time.deltaTime;
			tempScore = dateTime;
			score = tempScore * addSpeed; 
			strScore = score.ToString("F0");
			nowScoreText.text = /*"score:"*/"" + strScore;
			if(score >= levelLine[level]){
				change();
				Debug.Log (level);
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
		if((highScore < score) || (highScore == null)){
			highScore = score;
			PlayerPrefs.SetFloat("highScore",highScore);
			
		}
	}

	void change(){
		if(level <= enemySu){
			level++;
		}else{
	//		level = 0;
		}
	}

	public void getLevel (int level){
		this.level = level;
	}
	
	public int getSentLevel(){
		/*get{return level;}
		set{ level = value;}*/
        return level;
	}

	
}