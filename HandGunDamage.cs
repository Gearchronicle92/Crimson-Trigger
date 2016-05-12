using UnityEngine;
using System.Collections;

public class HandGunDamage : MonoBehaviour {



	int DamageAmount = 5;
	float TargetDistance  = 6f;
	int AllowedRange = 10; 

	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {

			Ray myRay = new Ray (transform.position, transform.TransformDirection (Vector3.forward));
			RaycastHit shot = new RaycastHit();
			if (Physics.Raycast (myRay, out shot, 1000f)) {
				TargetDistance = shot.distance;
				if (TargetDistance < AllowedRange) {
					shot.transform.SendMessage("DeductPoints", DamageAmount);
				}
			}
		}
	}
}
