using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotates any Walker instance which enters its trigger zone
/// </summary>
public class Rotator : MonoBehaviour {
	public float angle = 90;

	void OnTriggerEnter(Collider other){
		other.GetComponent<Walker>().WalkToPositionAndRotate(transform.position, angle);
	}

}
