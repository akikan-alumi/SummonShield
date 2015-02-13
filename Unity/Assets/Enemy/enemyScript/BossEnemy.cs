﻿using UnityEngine;
using System.Collections;

public class BossEnemy : MonoBehaviour {
    [SerializeField]
    private int Hp = 10;
    [SerializeField]
    private CircleCollider2D rad;
    public GameObject[] enemySield = new GameObject[3];
	[SerializeField]
	private GameObject kairo;
	private CircuitSwitch cirSwi;

	void Awake(){
		kairo = GameObject.Find ("CircuitSwitch").gameObject;
		cirSwi = kairo.GetComponent<CircuitSwitch>();

	}

    void Start() {
        rad = GetComponent<CircleCollider2D>();
        rad.radius = 1.86f;//初期状態のコライダーのradius
        enemySield[0] = transform.FindChild("BossEnemy2").gameObject;
        enemySield[1] = transform.FindChild("BossEnemy3").gameObject;
        enemySield[2] = transform.FindChild("BossEnemy4").gameObject;
		cirSwi.CSwitch ();
    }

    public void setHP() {
        Hp--;
        if (Hp < 1) {
			//ボス撃破でCSwitch起動
			cirSwi.CSwitch();
            Destroy(this.gameObject);
            Debug.Log("PlayerHit");


        }else if (Hp == 2) {
            Destroy(enemySield[0].gameObject);
            rad.radius = 0.65f;
        }else if(Hp == 5){
            Destroy(enemySield[1].gameObject);
            rad.radius = 1.02f;
        }else if(Hp == 8){
            Destroy(enemySield[2].gameObject);
            rad.radius = 1.28f;
        }
    }



}
