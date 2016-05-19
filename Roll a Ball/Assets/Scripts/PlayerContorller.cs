using UnityEngine;
using System.Collections;

public class PlayerContorller : MonoBehaviour {
	public float speed;	
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); 
		rb.AddForce (movement * speed);

		if (Input.GetKey (KeyCode.R)) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}

	// Destroy everything that enters the trigger
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive(false);
		}
	}
}