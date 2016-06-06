using UnityEngine;
using System.Collections;

public class RainCollision : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D coll) {
		Debug.logger.Log (coll.gameObject.tag);
		//coll.gameObject.SendMessage("Game Object tag", coll.gameObject.tag);
	}
}
