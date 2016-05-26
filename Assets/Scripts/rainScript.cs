using UnityEngine;
using System.Collections;

public class rainScript : MonoBehaviour {

	public GameObject[] rain; 
	public Transform camPos;
	public Camera cam;

	// Use this for initialization
	void Rain () {
		Instantiate (rain [Random.Range (0, rain.Length)], new Vector3 (Random.Range(camPos.position.x, camPos.position.x + 15f), camPos.position.y + 16, 0), Quaternion.identity);

	}

	void OnCollisionEnter2D(Collision2D coll) {
		Destroy (gameObject);

	}
	void Update () {
		camPos = cam.GetComponent<Transform> ();
	}
	// Update is called once per frame
	void Start () {
		InvokeRepeating ("Rain", .01f, Random.Range(.1f, .5f));
	}
}