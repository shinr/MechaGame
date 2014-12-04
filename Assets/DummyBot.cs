using UnityEngine;
using System.Collections;

public class DummyBot : MonoBehaviour {
	Vector3 force;
	// Use this for initialization
	void Start () {
		force = new Vector3 (-5.0f, 5.0f, 0.0f);
		Invoke ("ReverseHorizontal", 5.0f);
		Invoke ("ReverseVertical", 2.5f);
	}

	void ReverseHorizontal() {
		force.x *= -1.0f;
		Invoke ("ReverseHorizontal", 5.0f);
	}

	void ReverseVertical() {
		force.y *= -1.0f;
		Invoke ("ReverseVertical", 5.0f);
	}

	// Update is called once per frame
	void Update () {
		this.rigidbody.AddForce (force);
	}
}
