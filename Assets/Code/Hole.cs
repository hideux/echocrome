using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {
	VisiblityChecker visiblityChecker;
	
	SpriteRenderer spriteRenderer;

	Color initialColor;

	void Start () {
		visiblityChecker = GetComponent<VisiblityChecker>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		initialColor = spriteRenderer.color;
	}

	/// <summary>
	/// Makes the hole red when invisible. 
	/// Just added for debugging purposes.
	/// </summary>
	/// <param name="isVisible"></param>
	void OnVisiblityChanged(bool isVisible){
		if(isVisible){
			spriteRenderer.color = initialColor;
		}else{
			spriteRenderer.color = Color.red;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Player"){
			if(visiblityChecker.isVisible){
				Destroy(other.gameObject);
			}
		}
	}
}
