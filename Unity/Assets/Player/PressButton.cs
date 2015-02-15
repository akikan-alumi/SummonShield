using UnityEngine;
using System.Collections;

/// <summary>
/// ボタンが押されたときの処理
/// </summary>
public class PressButton : MonoBehaviour {

	/// <summary>
	/// 一時停止時に表示するCanvasを設定
	/// </summary>
	[SerializeField]
	private GameObject stopMenu;

	/// <summary>
	/// タイトル画面で,画面をタップする
	/// </summary>
	public void TapScreen(){
		Debug.Log ("Tap Screen");
	}

	/// <summary>
	/// ボタンが押されたら一時停止するメソッド
	/// </summary>
	public void PressButtonStop(){
		if (Time.timeScale != 0) {
			
			Time.timeScale = 0;
			stopMenu.SetActive(true);
			Debug.Log("Stop!");
		
		} else {
			
			Time.timeScale = 1;
			stopMenu.SetActive(false);
			Debug.Log("Start!");
		
		}
	}

	/// <summary>
	/// TitleButtonが押されたらTITLESceneに移動する
	/// </summary>
	public void PressButtonTitle(){
		Debug.Log ("Press Button Title");
        Application.LoadLevel(0);
	}

	/// <summary>
	/// RetryButtonが押されたらScene再読み込み
	/// </summary>
	public void PressButtonRetry(){
		Debug.Log ("Press Button Retry");
        if (Application.loadedLevelName == "normalMode") {
            Application.LoadLevel(1);
        }
        if (Application.loadedLevelName == "hardMode") {
            Application.LoadLevel(2);
        }
        if (Application.loadedLevelName == "Hell") {
            Application.LoadLevel(3);
        }
	}
}