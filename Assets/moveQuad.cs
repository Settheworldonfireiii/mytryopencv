﻿using UnityEngine;
using System.Collections;

public class moveQuad : MonoBehaviour {
	public Vector3 teleportPoint;
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
	}
}