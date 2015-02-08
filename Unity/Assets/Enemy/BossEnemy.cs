using UnityEngine;
using System.Collections;

public class BossEnemy : MonoBehaviour {
    [SerializeField]
    private int Hp = 10;

    public GameObject enemySield;
    //[SerializeField]
    //public GameObject player;
    /*[SerializeField]
    private float speed = 1;
    public GameObject obj;//playerを指定*/
    // Use this for initialization
    void Start() {
        //LookAt2D(obj);
        //Move(obj);

    }

    public void setHP() {
        Hp--;
        if (Hp < 1) {
            Destroy(this.gameObject);
            Debug.Log("PlayerHit");

        }
        else if (Hp == 2) {
            foreach (Transform t in this.transform) {
                Destroy(t.gameObject);
            }
        }
    }
}
