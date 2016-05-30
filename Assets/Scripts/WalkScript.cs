using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {
	
	float speed = 3f;
	public Animator anim;

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
		anim.SetFloat ("speed", 1);


	}
}
