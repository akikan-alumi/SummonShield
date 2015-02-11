using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {
	public GameObject CreditText;
	bool TriggerSwitch = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClick() { // MUST public
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
}