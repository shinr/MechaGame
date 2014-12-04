using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float life = 1.0f;
	// Use this for initialization
	void Start () {
		Invoke ("Death", life);
	}

	void Death() {
		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
