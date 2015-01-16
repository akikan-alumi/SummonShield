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

	void Start ()
	{
		scoreText = scoreTextObj.GetComponent<Text> ();
		nowScoreText = nowScoreTextObj.GetComponent<Text> ();

	}
	
	void Update ()
	{

		dateTime += Time.deltaTime;
		tempScore = (int)(dateTime);
		score = tempScore * addSpeed; 
		nowScoreText.text = "score:" + score;
		Debug.Log (dateTime);
	}

	public void GameOver()
	{
		canvas.SetActive (false);
		resultView.SetActive (true);
		scoreText.text = "score:" + score;

	}

}
