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
	private Text scoreText;
	[SerializeField]
	private float addSpeed = 1.5f;

	void Start ()
	{
		scoreText = scoreTextObj.GetComponent<Text> ();
	}
	
	void Update ()
	{

		dateTime += Time.deltaTime;
		Debug.Log (dateTime);
	}

	public void GameOver()
	{
		score = (int)((dateTime)*(addSpeed));
		resultView.SetActive (true);
		scoreText.text = "score:" + score;

	}

}
