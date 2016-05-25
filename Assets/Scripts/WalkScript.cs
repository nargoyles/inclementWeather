using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {

	float move;
	float speed = 3f;
	public Animator anim;
	// Update is called once per frame
	void Update () {
		move = Input.GetAxis ("Horizontal");
		if (Mathf.Abs (move) > 0) {
			transform.Translate(Vector3.right * move * speed * Time.deltaTime);
			anim.SetFloat ("speed", Mathf.Abs (move));

		
		}
	}
}
