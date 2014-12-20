using UnityEngine;
using System.Collections;

public class PressButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// [Easy]を押す
	/// </summary>
	public void PressButtonEasy(){
		Debug.Log ("Press Easy");
	}
	
	/// <summary>
	/// [Normal]を押す
	/// </summary>
	public void PressButtonNormal(){
		Debug.Log ("Press Normal");
	}
	
	/// <summary>
	/// [Hard]を押す
	/// </summary>
	public void PressButtonHard(){
		Debug.Log ("Press Hard");
	}
	
	/// <summary>
	/// [Credit]を押す
	/// </summary>
	public void PressButtonCredit(){
		Debug.Log ("Press Credit");
	}
	
	/// <summary>
	/// [Ranking]を押す
	/// </summary>
	public void PressButtonRanking(){
		Debug.Log ("Press Ranking");
	}
	
	/// <summary>
	/// [Option]を押す
	/// </summary>
	public void PressButtonOption(){
		Debug.Log ("Press Option");
	}
}
