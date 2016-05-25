using UnityEngine;
using System.Collections;

public class InstantiateScript : MonoBehaviour {

	public GameObject[] ground;

	// Use this for initialization
	void Start () {
		SpawnGround ();
	}

	void SpawnGround () {
		Instantiate(ground[Random.Range(0, ground.Length)], transform.position, Quaternion.identity);
		Invoke ("SpawnGround", Random.Range (1, 2));
	}
}
