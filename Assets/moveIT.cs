using UnityEngine;
using System.Collections;

public class moveIT : MonoBehaviour {
	public Vector3 min = new Vector3(-0.7f, 2.5f, 0);
	public Vector3 max = new Vector3(0.7f, 4.5f, 0);
	public float moveSpeed = 1.0f;

	void Update() {
		Vector3 newPosition = transform.position;
		var movePosition = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		newPosition += movePosition * moveSpeed * Time.deltaTime;
		if (newPosition.x > min.x &&
			newPosition.x < max.x &&
			newPosition.y > min.y &&
			newPosition.y < max.y) {
			transform.position += movePosition * moveSpeed * Time.deltaTime;
		}
	}
}
