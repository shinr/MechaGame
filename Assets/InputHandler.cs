using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {
	enum Actions {
		Up,
		Down,
		Left, 
		Right,
		Boost
	};
	bool[] keys = {false, false, false, false, false};
	public GameObject weapon;
	// Use this for initialization
	void Start () {
	}

	// do movement
	void FixedUpdate() {
		if (keys [(int)Actions.Up]) {
			this.rigidbody.AddForce (Vector3.up * 10.0f);
		}
		if (keys [(int)Actions.Down]) {
			this.rigidbody.AddForce (Vector3.down * 10.0f);
		}
		if (keys [(int)Actions.Left]) {
			this.rigidbody.AddForce (Vector3.left * 10.0f);
		}
		if (keys [(int)Actions.Right]) {
			this.rigidbody.AddForce (Vector3.right * 10.0f);
		}
		if (keys [(int)Actions.Boost]) {
			this.rigidbody.AddRelativeForce (Vector3.forward * 50.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			keys[(int)Actions.Up] = true;
		} else if (Input.GetKeyUp (KeyCode.W)) {
			keys[(int)Actions.Up] = false;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			keys[(int)Actions.Down] = true;
		} else if (Input.GetKeyUp (KeyCode.S)) {
			keys[(int)Actions.Down] = false;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			keys[(int)Actions.Left] = true;
		} else if (Input.GetKeyUp (KeyCode.A)) {
			keys[(int)Actions.Left] = false;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			keys[(int)Actions.Right] = true;
		} else if (Input.GetKeyUp (KeyCode.D)) {
			keys[(int)Actions.Right] = false;
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			keys[(int)Actions.Boost] = true;
		} else if (Input.GetKeyUp (KeyCode.Q)) {
			keys[(int)Actions.Boost] = false;
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			weapon = Instantiate(weapon, this.transform.position, this.transform.rotation) as GameObject;
			weapon.layer = 8;
		}
	}
}
