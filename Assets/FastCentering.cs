using UnityEngine;
using System.Collections;

public class FastCentering : MonoBehaviour {
	public Transform first;
	public Transform second;
	// Use this for initialization
	void Start () {
		
	}
	
	void Update() {
		Vector3 targetPosition = second.position + 0.5f * (first.position - second.position);
		targetPosition.z = this.transform.position.z;
		this.transform.position = targetPosition;
	}
}
