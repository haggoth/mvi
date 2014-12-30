using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	/// <summary>
	/// 1 - The speed of the ship
	/// </summary>
	public Vector2 speed = new Vector2(50, 50);
	public Vector2 accel = new Vector2(0.5f,0.25f);
	public Vector2 decel = new Vector2(0.75f, 0.75f);
	
	// 2 - Store the movement
	private Vector2 movement;
	
	void Update()
	{
		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 4 - Movement per direction
		movement += new Vector2(
			accel.x * inputX,
			accel.y * inputY);
		movement = new Vector2(movement.x * decel.x, movement.y * decel.y);
		
	}
	
	void FixedUpdate()
	{
		// 5 - Move the game object
		rigidbody2D.velocity = movement;
	}
}
