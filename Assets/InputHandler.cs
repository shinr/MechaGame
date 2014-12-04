using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {
	enum Actions {
		Up,
		Down,
		Left, 
		Right,
		Boost,
		Laser
	};
	bool[] keys = {false, false, false, false, false, false};
	// Use this for initialization
	void Start () {
	}

	// do movement
	void FixedUpdate() {
		if (keys [(int)Actions.Up] || Input.GetAxis ("Vertical") > 0.2f ) {
			this.rigidbody.AddForce (Vector3.up * 10.0f);
		}
		if (keys [(int)Actions.Down] || Input.GetAxis ("Vertical") < -0.2f) {
			this.rigidbody.AddForce (Vector3.down * 10.0f);
		}
		if (keys [(int)Actions.Left] || Input.GetAxis ("Horizontal") < -0.2f) {
			this.rigidbody.AddForce (Vector3.left * 10.0f);
		}
		if (keys [(int)Actions.Right] || Input.GetAxis ("Horizontal") > 0.2f) {
			this.rigidbody.AddForce (Vector3.right * 10.0f);
		}
		if (keys [(int)Actions.Boost]) {
			this.rigidbody.AddRelativeForce (Vector3.forward * 50.0f);
		}
		if (keys [(int)Actions.Laser]) {
			if(this.GetComponent<Weapon>().canFire) {
				this.GetComponent<Weapon>().Fire ();
			}
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
			keys[(int)Actions.Laser] = true;
		} else if (Input.GetKeyUp (KeyCode.E)) {
			keys[(int)Actions.Laser] = false;
		}
	}
}
