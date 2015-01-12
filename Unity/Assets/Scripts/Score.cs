using UnityEngine;

public class Score : MonoBehaviour
{
	// スコアを表示するGUIText
	public GUIText GameScoreGUIText;
	
	// ハイスコアを表示するGUIText
	public GUIText GameHighScoreGUIText;
	
	// スコア
	private int GameScore;
	
	// ハイスコア
	private int GameHighScore;
	
	// PlayerPrefsで保存するためのキー
	private string HighScoreKey = "HighScore";

	float remainintTime = 0f;
	
	void Start ()
	{
		Initialize ();
	}
	
	void Update ()
	{
		float dateTime = Time.deltaTime;
		remainintTime -= dateTime;

		// スコアがハイスコアより大きければ
		if (GameHighScore < GameScore) {
			GameHighScore = GameScore;
		}
		
		// スコア・ハイスコアを表示する
		GameScoreGUIText.text = GameScore.ToString ();
		GameHighScoreGUIText.text = "HighScore : " + GameHighScore.ToString ();
	}
	
	// ゲーム開始前の状態に戻す
	private void Initialize ()
	{
		// スコアを0に戻す
		GameScore = 0;
		
		// ハイスコアを取得する。保存されてなければ0を取得する。
		GameHighScore = PlayerPrefs.GetInt (HighScoreKey, 0);
	}
	
	// ポイントの追加
	public void AddPoint (int point)
	{
		GameScore = GameScore + point;
	}
	
	// ハイスコアの保存
	public void Save ()
	{
		// ハイスコアを保存する
		PlayerPrefs.SetInt (HighScoreKey, GameHighScore);
		PlayerPrefs.Save ();
		
		// ゲーム開始前の状態に戻す
		Initialize ();
	}
}