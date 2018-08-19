using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 10;
	// Use this for initialization
	void FixedUpdate () {
		// bool isRight = OVRInput.Get(OVRInput.Button.Right);
		Vector2 touchPadPt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
		float x = touchPadPt.x;
		float z = touchPadPt.y;

		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.AddForce(x, 0, z);

		rigidbody.AddForce(x * speed, 0, z * speed);
	}

	// Update is called once per frame
	void Update () {

	}
}
