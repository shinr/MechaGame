using UnityEngine;
using System.Collections;

public class SlowCentering : MonoBehaviour {
	public Transform first;
	public Transform second;
	Transform begin;
	Transform end;
	// Use this for initialization
	void Start () {
		
	}
	
	void Update() {
		begin = first;
		end = second;
		if (begin != null && end != null) {
		} else {
			if(begin == null) {
				begin = this.transform;
			}
			if(end == null) {
				end = this.transform;
			}
		}
		Vector3 targetPosition = end.position + 0.5f * (begin.position - end.position);
		targetPosition.z = this.transform.position.z;
		this.transform.position = Vector3.Lerp (this.transform.position, targetPosition, 0.01f);
	}

}
