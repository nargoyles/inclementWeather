using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {
	
	float speed = 3f;
	public Animator anim;
	public float jumpForce = 5f;
	bool jumping = false;
	public float distance = 1f;
	public Rigidbody2D beckard;
	public LayerMask ground;

	// Update is called once per frame
	void FixedUpdate(){
		
		GroundCheck();

	}

	void Update () {

		//auto-walking
		transform.Translate(Vector3.right * speed * Time.deltaTime);
		anim.SetFloat ("speed", 1);

		//jumping
		if(Input.GetKey(KeyCode.Space) && !jumping){
			beckard.AddForce(new Vector2(0, jumpForce));
		}

	}

	void GroundCheck()
	{
		RaycastHit hit;
		Vector3 dir = new Vector3(0, -1);

		if(beckard.IsTouchingLayers(ground))
		{
			jumping = false;
			anim.SetBool ("jump", false);
		}
		else
		{
			jumping = true;
			anim.SetBool ("jump", true);
		}
	}
}
