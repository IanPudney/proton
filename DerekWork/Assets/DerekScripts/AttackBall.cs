﻿using UnityEngine;
using System.Collections;

public class AttackBall : MonoBehaviour {
	Vector3 directionVector;
	public int level;
	private float time;
	// Use this for initialization
	void Start () {
		level = (int)transform.rotation.x;
		time = 0;
		directionVector = new Vector3 ();
		directionVector.x = 0 - this.transform.position.x;
		directionVector.y = 0 - this.transform.position.y;
		directionVector.z = 0 - 10 - this.transform.position.z;
		directionVector.Normalize ();
		directionVector.x = directionVector.x / 40.0f;
		directionVector.y = directionVector.y / 40.0f;
		directionVector.z = directionVector.z / 40.0f;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		Vector3 modificationVector = Vector3.zero;
		if (level == 3) {
			modificationVector.z = 0.17f * Mathf.Sin (3.1f * time + 1f);
		} if (level >= 2) {
			modificationVector.y = 0.13f * Mathf.Cos (1.5f * time);
		} if (level >= 1) {
			modificationVector.x = 0.1f * Mathf.Sin (time);
		}
		transform.Translate (directionVector + modificationVector, Space.World);
	}
}
