using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	// 初期値セット
	private int score = 0;
	private int tempScore = 0;
	private float dateTime = 0;
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
	private int addSpeed = 128;
	private GameObject[] spawners;
	private bool gameOver;


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
			tempScore = (int)(dateTime);
			score = tempScore * addSpeed; 
			nowScoreText.text = "score:" + score;
			Debug.Log (dateTime);
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
		scoreText.text = "score:" + score;

	}

}
