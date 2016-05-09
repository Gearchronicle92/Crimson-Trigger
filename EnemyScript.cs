using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {


	int enemyHealth; //what is this for?


	// Use this for initialization
	void Start () {
		enemyHealth  = 10;
		

	}

	void DeductPoints (int DamageAmount)  { //what does this function do?
		enemyHealth -= DamageAmount; //what is happening here?
	}

	// Update is called once per frame
	void Update () {
		if (enemyHealth <= 0) { //what condition is being checked?
			Destroy (gameObject); //what does this do?
		}

	}
}
