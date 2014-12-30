using UnityEngine;
using System.Collections;

public class UnitScript : MonoBehaviour {
	
	// 1 - Designer variables
	
	/// <summary>
	/// Object speed
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);

	/// <summary>
	/// Health: number of hits before leaving.
	/// </summary>
	public int hp = 1;

	private Vector2 movement;
	
	void Update()
	{
		// 2 - Movement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		// Bounce in the opposite direction when colliding
		rigidbody2D.position = new Vector2(rigidbody2D.position.x - direction.x * 2,
		                                   rigidbody2D.position.y - direction.y * 2);
		//direction = new Vector2(direction.x * -1, direction.y * -1);
		if(--hp <= 1){
			(renderer as SpriteRenderer).color = Color.red;
		}
		if(hp <= 0){
			(renderer as SpriteRenderer).sprite = null;
			Destroy(this);
			BoxCollider2D.Destroy(collider2D);
		}
	}
}
