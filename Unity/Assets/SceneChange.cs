﻿using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoNormalScene()
	{
		Application.LoadLevel (1);
	}
}
