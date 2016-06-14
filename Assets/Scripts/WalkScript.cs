using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {
	
	float speed = 3f;
	public Animator anim;
	public Vector2 jumpForce = new Vector2(0, 10);
	bool jumping = false;
	public float distance = 1f;
	public Rigidbody2D beckard;
	public LayerMask ground;
	public Vector2 velocity;

	// Update is called once per frame
	void FixedUpdate(){
		
		//GroundCheck();
		if(Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			Debug.Log(beckard.velocity);
			anim.CrossFade ("jump", 0f);
			//beckard.AddForce(new Vector2(0, 100));
			//transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
			GetComponent<Rigidbody2D>().AddForce(jumpForce, ForceMode2D.Impulse);
		}
	}

	void Update () {
		//auto-walking
		transform.Translate(speed * Time.deltaTime, 0, 0);
		anim.SetFloat("speed", 1);
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
