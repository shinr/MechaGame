using UnityEngine;
using System.Collections;

public class LateOverview : MonoBehaviour {
	public Transform first;
	public Transform second;
	Transform begin;
	Transform end;
	// Use this for initialization
	void Start () {
	
	}

	void LateUpdate() {
		Vector3 targetPosition = Vector3.zero;
		begin = first;
		end = second;
		if (begin != null && end != null) {
			targetPosition = end.position + 0.5f * (begin.position - end.position);
		} else {
			if(begin == null) {
				targetPosition = end.position + 0.5f * (Vector3.zero - end.position);
			} 
			if(end == null) {
				targetPosition = Vector3.zero + 0.5f * (begin.position);
			}
		}
		this.transform.LookAt (targetPosition);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
