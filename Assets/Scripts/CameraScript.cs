using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform character;

	void Update ()
	{

		transform.position = new Vector3 (character.position.x + 6, 3, -10);
	
	}
}
