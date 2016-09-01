using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float velocity;
	Rigidbody2D body;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		body.velocity = Vector2.zero;

		if (Input.GetKey (KeyCode.UpArrow)) {
			body.velocity = new Vector2 (body.velocity.x, velocity);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			body.velocity = new Vector2 (body.velocity.x, -velocity);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			body.velocity = new Vector2 (-velocity, body.velocity.y);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			body.velocity = new Vector2 (velocity, body.velocity.y);
		}
	}
}
