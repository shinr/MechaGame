using UnityEngine;
using System.Collections;

public class LateTargeting : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (target) {
			this.transform.LookAt(target.transform.position);
		}
	}
}
