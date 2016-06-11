using UnityEngine;
using System.Collections;

public class moveIT : MonoBehaviour {
	public Vector3 min = new Vector3(-1.7f, 1.5f, 0);
	public Vector3 max = new Vector3(0.7f, 4.5f, 0);
	public float moveSpeed = 1.0f;

	private Vector3 getContainedPosition(Vector3 movePosition, Vector3 newPosition) {
		if (newPosition.x > min.x && newPosition
	}

	void Update() {
		var movePosition = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		Vector3 newPosition = transform.position + movePosition * moveSpeed * Time.deltaTime;
		Vector3 containedPosition = getContainedPosition (movePosition, newPosition);
		transform.position = containedPosition;
	}
}
