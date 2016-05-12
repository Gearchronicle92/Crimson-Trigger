using UnityEngine;
using System.Collections;

public class Gunfire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
		void Update() {
			if(Input.GetButtonDown("Fire1")) { // mouse button 
			Debug.Log("Fire1 is being pressed");
				 AudioSource gunsound = GetComponent<AudioSource>(); // Creating Gunsound 
				gunsound.Play();
				GetComponent<Animation>().Play("GunShot"); // Animate Gun when firing
			}
		} 
	   
	

	
	}

