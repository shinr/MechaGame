using UnityEngine;
using System.Collections;

public class ProjLaser : MonoBehaviour {
	Vector3 speed;
	float speedMultiplier = 20.0f;
	void OnCollisionEnter(Collision collision) {
		Destroy (this.gameObject);
	}
	// Use this for initialization
	void Start () {
		speed = this.transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
		this.rigidbody.AddForce (speed * speedMultiplier);
	}
}
