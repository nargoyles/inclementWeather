using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {
	
	float speed = 3f;
	public Animator anim;
	public Vector2 jumpForce = new Vector2(0, 10);
	bool jumping = false;
	public float distance = 1f;
	public Rigidbody2D beckardHolder;
	public LayerMask ground;
	public Vector2 velocity;

	void FixedUpdate(){		
		GroundCheck();
		if(Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0) && !jumping){
			Debug.Log(beckardHolder.velocity);
			anim.CrossFade ("jump", 1f);
			beckardHolder.AddForce(jumpForce, ForceMode2D.Impulse);
		}
	}

	void Update () {
		transform.Translate(speed * Time.deltaTime, 0, 0);
		anim.SetFloat("speed", 1);
	}

	void GroundCheck() {
		if(beckardHolder.IsTouchingLayers(ground))
		{
			jumping = false;
			Debug.Log ("Not touching");
		}
		else
		{
			jumping = true;
			Debug.Log ("Touching");
		}
	}
}
