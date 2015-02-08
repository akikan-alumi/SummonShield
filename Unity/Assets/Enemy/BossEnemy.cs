using UnityEngine;
using System.Collections;

public class BossEnemy : MonoBehaviour {
    [SerializeField]
    private int Hp = 10;

    public GameObject[] enemySield = new GameObject[3];
    //[SerializeField]
    //public GameObject player;
    /*[SerializeField]
    private float speed = 1;
    public GameObject obj;//playerを指定*/
    // Use this for initialization
    void Start() {
        //LookAt2D(obj);
        //Move(obj);
        enemySield[0] = transform.FindChild("BossEnemy2").gameObject;
        enemySield[1] = transform.FindChild("BossEnemy3").gameObject;
        enemySield[2] = transform.FindChild("BossEnemy4").gameObject;
    }

    public void setHP() {
        Hp--;
        if (Hp < 1) {
            Destroy(this.gameObject);
            Debug.Log("PlayerHit");

        }else if (Hp == 2) {
            Destroy(enemySield[0].gameObject);
        }else if(Hp == 5){
            Destroy(enemySield[1].gameObject);
        }else if(Hp == 8){
            Destroy(enemySield[2].gameObject);
        }
    }
}
