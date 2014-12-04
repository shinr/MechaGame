using UnityEngine;
using System.Collections;

public class SlowCentering : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	void Update() {
		Vector3 targetPosition = Vector3.zero;
		foreach (Transform t in GetComponent<EntityTracker>().trackedEntities) {
			targetPosition += t.position;
		}
		targetPosition /= GetComponent<EntityTracker>().trackedEntities.Length;
		Debug.DrawLine (Vector3.zero, targetPosition);
		targetPosition.z = this.transform.position.z;
		this.transform.position = Vector3.Lerp (this.transform.position, targetPosition, 0.01f);
	}

}
