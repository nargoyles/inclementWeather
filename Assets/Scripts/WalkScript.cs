using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {

	public float speed = 3f;
	public Animator anim;
	public Vector2 jumpForce = new Vector2(0, 5);
	public bool grounded;
	public float distance = 1f;
	public Rigidbody2D beckardBody;
	public Transform beckardTransform;
	public Transform groundCheck;
	public Vector2 velocity;

	void FixedUpdate () {
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("ground"));
		if (grounded) {
			anim.SetBool ("jump", false);
		}
		beckardTransform.Translate(speed * Time.deltaTime, 0, 0);
		anim.SetFloat("speed", 1);
		if((Input.GetKey(KeyCode.Space) || Input.GetMouseButtonUp(0)) && grounded){
			jump();
		}
	}

	void jump() {
		anim.SetBool ("walk", false);
		anim.CrossFade ("jump", 0f);
		beckardBody.AddForce(jumpForce, ForceMode2D.Impulse);
	}

}