using UnityEngine;
using System.Collections;

public class EntityTracker : MonoBehaviour {
	public Transform [] trackedEntities;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddEntity(Transform go) {
		trackedEntities [trackedEntities.Length] = go;
	}
}
