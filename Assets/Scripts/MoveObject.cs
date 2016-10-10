using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {
	public float moveX;
	public float moveY;


	void Update () {
		transform.Translate(moveX * Time.deltaTime, moveY * Time.deltaTime, 0);
	}
}
