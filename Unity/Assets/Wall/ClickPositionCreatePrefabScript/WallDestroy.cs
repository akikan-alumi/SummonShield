﻿using UnityEngine;
using System.Collections;

public class WallDestroy : MonoBehaviour {
	//int roop = 0;
	//new int arrayWall[5];
	// Use this for initialization
	void Start () {
	
		//シーンから削除する場合
		Destroy(this.gameObject,5.0f);


	}
	
	// Update is called once per frame
	void Update () {

	}
}