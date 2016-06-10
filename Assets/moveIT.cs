using UnityEngine;
using System.Collections;

public class moveIT : MonoBehaviour {
	
		public float speed = 10.0F;
		public float pitchSpeed = 100.0F;
		
		// Update is called once per frame
		void Update () {
			float pitch = Input.GetAxis("Horizontal") * pitchSpeed;
			pitch *= Time.deltaTime;
			transform.Rotate(0, 0, pitch * -1);

			float translation = Input.GetAxis("Vertical") * speed;
			translation *= Time.deltaTime;

			if (Mathf.Abs(Input.GetAxis("Vertical")) > 0) {
				while(Mathf.Abs(Input.GetAxis("Vertical")) > 0 && transform.position.y < 7 && transform.position.y > 2){
					
					transform.Translate (0, translation, 0, Space.World);
			}
		
		}
		}
	}