using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	// 初期値セット
	private int score = 0;
	private float dateTime = 0;
	[SerializeField] 
	private GameObject resultView;
	[SerializeField]
	private GameObject scoreTextObj;
	[SerializeField]
	private GameObject nowScore;
	[SerializeField]
	private GameObject nowScoreTextObj;
	private Text nowScoreText;
	private Text scoreText;
	[SerializeField]
	private float addSpeed = 1.5f;

	void Start ()
	{
		scoreText = scoreTextObj.GetComponent<Text> ();
		nowScoreText = nowScoreTextObj.GetComponent<Text> ();

	}
	
	void Update ()
	{

		dateTime += Time.deltaTime;
		score = (int)(dateTime);
		nowScoreText.text = "score:" + score;
		Debug.Log (dateTime);
	}

	public void GameOver()
	{
		score = (int)(dateTime);
		nowScore.SetActive (false);
		resultView.SetActive (true);
		scoreText.text = "score:" + score;

	}

}
