using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checks whether the object is visible by the main camera continously 
/// and sends OnVisiblityChanged message when the value of the isVisible variable gets changed
/// </summary>
public class VisiblityChecker : MonoBehaviour {
	[System.NonSerializedAttribute]
	public bool isVisible;

	Transform t;

	Transform cam;

	public LayerMask layerMask;

	void Start () {
		t = transform;
		cam = Camera.main.transform;
	}
	
	void Update () {
		// Since the cam is orthographic, we can directly check whether the ray 
		// starting from t.position to the direction of -camForward hit any obstacles
		// to be sure that the item is visible
		Vector3 camForward = cam.forward;
		if(Physics.Raycast(t.position-camForward*0.1f, -camForward, 1000, layerMask)){
			if(isVisible){
				isVisible = false;
				this.SendMessage("OnVisiblityChanged", isVisible, SendMessageOptions.DontRequireReceiver);
			}
		}else{
			if(!isVisible){
				isVisible = true;
				this.SendMessage("OnVisiblityChanged", isVisible, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
