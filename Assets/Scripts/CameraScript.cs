using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform character;
	public Vector3 cameraPosition;
	public float xAdjustment = 0;
	public float yAdjustment = 0;

	void Update () {
		cameraPosition = new Vector3(character.position.x + xAdjustment, yAdjustment, 0);
		transform.position = cameraPosition;
	}
}
