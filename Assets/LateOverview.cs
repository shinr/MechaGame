using UnityEngine;
using System.Collections;

public class LateOverview : MonoBehaviour {
	public Transform first;
	public Transform second;
	// Use this for initialization
	void Start () {
	
	}

	void LateUpdate() {
		Vector3 targetPosition = second.position + 0.5f * (first.position - second.position);
		this.transform.LookAt (targetPosition);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
