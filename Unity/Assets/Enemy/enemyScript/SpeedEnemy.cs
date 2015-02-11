using UnityEngine;
using System.Collections;

public class SpeedEnemy : MonoBehaviour {

    [SerializeField]
    private int Hp = 1;

    public void setHP() {
        Hp--;
        if (Hp < 1) {
            Destroy(this.gameObject);
            Debug.Log("PlayerHit");

        }

    }
}
