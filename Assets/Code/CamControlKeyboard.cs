using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControlKeyboard : MonoBehaviour {
	Transform t;

	public Vector3 speed = new Vector3(40, 40, 0);

	void Start () {
		t = transform;
	}
	
	void Update () {
		t.Rotate(Input.GetAxis("Vertical")*Time.deltaTime*speed.x, Input.GetAxis("Horizontal")*Time.deltaTime*speed.y, 0);
	}
}
