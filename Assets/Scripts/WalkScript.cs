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
	Puppet2D_GlobalControl gc;

	// Update is called once per frame
	void FixedUpdate(){
		
		GroundCheck();

	}

	void Update () {

		//auto-walking
		gc.transform.Translate(new Vector3((speed * Time.deltaTime), 0, 0));
		anim.SetFloat ("speed", 1);

		//jumping
		if(Input.GetKey(KeyCode.Space) && !jumping){
			beckard.AddForce(new Vector2(0, jumpForce));
		}

	}

	void GroundCheck()
	{

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
