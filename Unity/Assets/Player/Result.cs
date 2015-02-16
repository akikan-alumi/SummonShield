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
	private Text nowScoreText;
	private Text scoreText;
	[SerializeField]
	private float addSpeed = 0.125f;
	private GameObject[] spawners;
	private bool gameOver;
	private string strScore;
	private static float highScore;
	
	void awake(){
		highScore = PlayerPrefs.GetFloat ("highScore");
	}	
	
	void Start ()
	{
		scoreText = scoreTextObj.GetComponent<Text> ();
		nowScoreText = nowScoreTextObj.GetComponent<Text> ();
		gameOver = false;
		spawners  = GameObject.FindGameObjectsWithTag("Spawner");
		
		
	}
	
	void Update ()
	{
		if(gameOver == false){
			dateTime += Time.deltaTime;
			tempScore = dateTime;
			score = tempScore * addSpeed; 
			strScore = score.ToString("F0");
			nowScoreText.text = /*"score:"*/"" + strScore;
			//Debug.Log (dateTime);
		}
	}
	
	public void GameOver()
	{
		gameOver = true;
		foreach (GameObject spa in spawners) {
			Destroy(spa);
		}
		canvas.SetActive (false);
		resultView.SetActive (true);
		Time.timeScale = 0;
		scoreText.text = "score:" + strScore;
		if((highScore < score) || (highScore == null)){
			highScore = score;
			PlayerPrefs.SetFloat("highScore",highScore);
			
		}
	}
}
