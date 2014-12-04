using UnityEngine;
using System.Collections;

public class KeepOnView : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Transform [] tracked = GetComponent<EntityTracker> ().trackedEntities;
		Vector3 min = transform.position;
		Vector3 max = transform.position;
		Vector3 targetPosition = transform.position;
		float radiusX, radiusY;
		foreach (Transform t in tracked) {
			if(t.position.x < min.x) {
				min.x = t.position.x;
			} else if(t.position.x > max.x) {
				max.x = t.position.x;
			}
			if(t.position.y < min.y) {
				min.y = t.position.y;
			} else if(t.position.y > max.y) {
				max.y = t.position.y;
			}
		}
		if (max.x > Mathf.Abs (min.x)) {
			radiusX = max.x;
		} else {
			radiusX = min.x * -1.0f;
		}
		if (max.y > Mathf.Abs (min.y)) {
			radiusY = max.y;
		} else {
			radiusY = min.y * -1.0f;
		}
		float distance;
		if (radiusX > radiusY) {
			distance = radiusX / (float)Mathf.Sin (camera.fieldOfView / 2);
		} else {
			distance = radiusY / (float)Mathf.Sin (camera.fieldOfView / 2);
		}
		targetPosition.z = distance;
		this.transform.position = Vector3.Lerp (this.transform.position, targetPosition, 0.04f);
	}
}
