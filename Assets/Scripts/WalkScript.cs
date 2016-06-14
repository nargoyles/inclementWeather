using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {

	float speed = 3f;
	public Animator anim;
	public Vector2 jumpForce = new Vector2(0, 5);
	public bool grounded;
	public float distance = 1f;
	public Rigidbody2D beckardHolder;
	public Transform beckardHolderTrans;
	public Transform groundCheck;
	public Vector2 velocity;

	void Update () {
		beckardHolderTrans.Translate(speed * Time.deltaTime, 0, 0);
		anim.SetFloat("speed", 1);
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("ground"));
		if(Input.GetKey(KeyCode.Space) && grounded || Input.GetMouseButtonDown(0) && grounded){
			jump();
		}
	}

	void jump() {
		anim.CrossFade ("jump", 1f);
		beckardHolder.AddForce(jumpForce, ForceMode2D.Impulse);
	}

}