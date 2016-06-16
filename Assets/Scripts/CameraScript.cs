using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform character;
	public Vector3 cameraPosition;

	void Update () {
		cameraPosition = new Vector3 (character.position.x, 0, 0);
		transform.position = cameraPosition;
	}
}
