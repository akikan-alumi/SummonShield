using UnityEngine;
using System.Collections;

public class enemysAI : MonoBehaviour {

    public Transform target;
    private Vector2 vec;
    private float speed = 0.07f;
	private float myLife = 5.0f;

    private void Start() {
        //target = GameObject.FindGameObjectWithTag("Player").transform;
		Destroy (this.gameObject,myLife);
    }

    private void Update() {

        straight();
    }

    public void straight() {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position),0.1f);
        
        //transform.position += transform.right * speed;
		//transform.LookAt2D (this.transform,Vector2.up);
    }
    public void setSpeed() {
        speed = 0.14f;
    }
}
