using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleHiScore : MonoBehaviour {
	private static float highScore;
	private Text scoreText;
	[SerializeField]
	private GameObject scoreTextObj;
	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetFloat ("highScore");
		scoreText = scoreTextObj.GetComponent<Text> ();
		if ((highScore == 0) || (highScore == null)){
			scoreText.text = "-";
		}else{		
			scoreText.text = "" + highScore.ToString("F0");
		}
	}

}
