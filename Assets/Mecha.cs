using UnityEngine;
using System.Collections;

public class Mecha : MonoBehaviour {
	public float health = 2000.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Damage(float damage) {
		this.health -= damage;
		if (this.health < 0.0f) {
			Destroy (this.gameObject);
		}
	}
}
