using UnityEngine;
using System.Collections;

public class ProjLaser : MonoBehaviour {
	Vector3 speed;
	float speedMultiplier = 40.0f;
	void OnCollisionEnter(Collider collision) {
		Destroy (this);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.rigidbody.AddForce (speed * speedMultiplier);
	}
}
