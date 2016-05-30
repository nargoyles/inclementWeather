using UnityEngine;
using System.Collections;

public class destroyScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		Destroy (gameObject);

	}
}