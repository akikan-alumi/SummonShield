using UnityEngine;
using System.Collections;

public class enemysAI : MonoBehaviour {

    public Transform target;
    private Vector2 vec;
    private float speed = 0.07f;

    private void Start() {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update() {
        straight();
    }
    public void straight() {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position),0.01f);
        
        transform.position += transform.up * -speed;
    }
    public void setSpeed() {
        speed = 0.14f;
    }
}
