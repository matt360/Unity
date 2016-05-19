using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		gameObject.transform.Rotate (new Vector3 (moveVertical, 0.0f, moveHorizontal) * Time.deltaTime * speed);

	}
}
		                       