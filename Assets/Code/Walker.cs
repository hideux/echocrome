using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the object to the direction of forward(blue) vector with the given speed
/// </summary>
public class Walker : MonoBehaviour {

	Rigidbody rb;

	Transform t;

	public float speed = 2;

	float sleepTimer = 0;

	void Start(){
		rb = GetComponent<Rigidbody>();
		t = transform;
	}

	void Update(){
		if(sleepTimer>0)
			sleepTimer-=Time.deltaTime;
		
		rb.MovePosition(t.position + t.forward*Time.deltaTime*speed);
	}

	/// <summary>
	/// Aligns the object to the given position and angle strictly
	/// </summary>
	/// <param name="targetPosition"></param>
	/// <param name="angle"></param>
	public void WalkToPositionAndRotate(Vector3 targetPosition, float angle){
		if(sleepTimer>0)
			return;

		//TODO: Animate

		sleepTimer = 1;
		t.position = targetPosition;
		t.Rotate(0, angle, 0);
	}

}
