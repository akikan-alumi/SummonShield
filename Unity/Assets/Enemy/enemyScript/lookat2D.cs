using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class lookat2D : MonoBehaviour {
    [SerializeField]
	private float speed = 1;
	//playerを指定
	[SerializeField]
	private GameObject obj;

	//public CircuitChild  cChild;
	//public CircuitParent cParent;
	
	//private GameObject circuit
    void Update() {

		LookAt2D (obj);
    }

	void FixedUpdate(){
		Move (obj);
	}

    void Move(GameObject target) {
        // (target.transform.position - transform.position)だけでは
        // 距離によって移動速度が変わる
        //よってnormalizedで一定速度にする
        rigidbody2D.velocity = (target.transform.position - transform.position).normalized * speed;
    }

    void LookAt2D(GameObject target) {
        // 指定オブジェクトと回転させるオブジェクトの位置の差分(ベクトル)
        Vector3 pos = target.transform.position - transform.position;
        // ベクトルのX,Yを使い回転角を求める
        float angle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        Quaternion rotation = new Quaternion();
        // 回転角は右方向が0度なので-90
        rotation.eulerAngles = new Vector3(0, 0, angle - 90);
        // 回転
        transform.rotation = rotation;
    }

	/*void OnDestroy(){
		if (cChild != null) {
			cChild.EnabledSwitch (true);
		}
		if (cParent != null){
			cParent.EnabledSwitch (true);
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.CompareTag ("Circuit")) {
			if(col.gameObject.GetComponent<CircuitChild>() != null){
				cChild = col.gameObject.GetComponent<CircuitChild>();
			} else if(col.gameObject.GetComponent<CircuitParent>() != null){
				cParent = col.gameObject.GetComponent<CircuitParent>();
			}
		}
	}*/
}