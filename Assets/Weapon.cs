using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public bool canFire = true;
	public float cooldown = 1.0f;
	public GameObject projectile;
	float timer = 99.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timer < cooldown) {
			canFire = false;
		}
		if (!canFire) {
			if(timer < cooldown) {
				timer += Time.deltaTime;
			}
			else {
				canFire = true;
			}
		}
	}

	public void Fire() {
		if (canFire) {
			timer = 0.0f;
			Instantiate (projectile, this.transform.position, this.transform.rotation);
		}
	}
}
