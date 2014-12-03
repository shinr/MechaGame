using UnityEngine;
using System.Collections;

public class ProjLaser : MonoBehaviour {
	public float damage = 500.0f;
	Vector3 speed;
	float speedMultiplier = 20.0f;
	void OnCollisionEnter(Collision collision) {
		Destroy (this.gameObject);
		collision.gameObject.SendMessage ("Damage", damage);
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
