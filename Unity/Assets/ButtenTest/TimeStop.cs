using UnityEngine;
using System.Collections;

public class TimeStop : MonoBehaviour {

	/// <summary>
	/// 
	/// </summary>
	[SerializeField]
	private GameObject stopMenu;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// ボタンが押されたら一時停止するメソッド
	/// </summary>
	public void Stop(){
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

	public void GoTitle(){
		Debug.Log ("Titleへシーン遷移します");
		//Application.loadedLevel ("タイトルシーンへ");
	}
}
