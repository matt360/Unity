using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	public float speed;
	public Boundary boundary;

	private Rigidbody2D rb2d;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
		
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.velocity = movement * speed;

		rb2d.position = new Vector2 (rb2d.position.x, rb2d.position.y);
			/*(
				Mathf.Clamp (rb2d.position.x, boundary.xMin, boundary.xMax),  
				Mathf.Clamp (rb2d.position.y, boundary.zMin, boundary.zMax)
			);*/

		//rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * -tilt);
	}



	void OnTriggerEnter2D(Collider2D other) 
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
		}
	}
}
