using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    float speed = 1; 
    public GameObject obj;//playerを指定

    void Update() {

        LookAt2D(obj);
        Move(obj);


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
}
