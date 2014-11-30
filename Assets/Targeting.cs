using UnityEngine;
using System.Collections;

public class Targeting : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			this.transform.LookAt(target.transform.position);
		}
	}
}
