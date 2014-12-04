using UnityEngine;
using System.Collections;

public class LateOverview : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}

	void LateUpdate() {
		Vector3 targetPosition = Vector3.zero;
		foreach (Transform t in GetComponent<EntityTracker>().trackedEntities) {
			targetPosition += t.position;
		}
		targetPosition /= GetComponent<EntityTracker>().trackedEntities.Length;
		Debug.DrawLine (Vector3.zero, targetPosition);
		this.transform.LookAt (targetPosition);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
