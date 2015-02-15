﻿using UnityEngine;
using System.Collections;

public class TitleButton : MonoBehaviour {
	public GameObject CreditText;
	bool TriggerSwitch = false;

	/// <summary>
	/// クレジットボタンをタップした時
	/// </summary>
	public void TapCredit() 
	{
		//Debug.Log ("clicked");
		if(TriggerSwitch == false){
			//Trigger ON 
			CreditText.SetActive(true); 
			TriggerSwitch = true;
			Debug.Log ("ON");
		}else if(TriggerSwitch == true){
			// Trigger OFF 
			CreditText.SetActive(false); 
			TriggerSwitch = false;
			Debug.Log ("OFF");
		}
	}

	/// <summary>
	/// ノーマルボタンをタップした時
	/// </summary>
	public void TapNormal()
	{
		//シーン遷移
        Application.LoadLevel(1);
		Debug.Log ("TapNormalButton");
	}

	/// <summary>
	/// ハードボタンをタップした時
	/// </summary>
	public void TapHard()
	{
		//シーン遷移
        Application.LoadLevel(2);
		Debug.Log ("TapHardButton");
	}

	/// <summary>
	/// ヘルボタンをタップした時
	/// </summary>
	public void TapHell()
	{
		//シーン遷移
        Application.LoadLevel(3);
		Debug.Log ("TapHellButton");
	}
}