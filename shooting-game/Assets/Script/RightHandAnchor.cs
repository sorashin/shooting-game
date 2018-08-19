using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandAnchor : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
			if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)){
				GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				bullet.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
				bullet.transform.position = transform.position;
				Rigidbody body = bullet.AddComponent <Rigidbody>();
				Vector3 force = transform.forward * 20.0f;
				body.AddForce(force, ForceMode.Impulse);
				body.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
				Destroy(bullet, 1.0f);
			}

	}
}
