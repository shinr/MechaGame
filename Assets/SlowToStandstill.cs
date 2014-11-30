using UnityEngine;
using System.Collections;
// slows down an object
public class SlowToStandstill : MonoBehaviour {
	public bool useSlowdown = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!rigidbody.IsSleeping () && useSlowdown) {
			rigidbody.drag = 2.0f;
		} else {
			rigidbody.drag = 0.0f;
		}
	}
}
