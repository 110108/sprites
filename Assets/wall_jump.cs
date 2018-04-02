using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_jump : MonoBehaviour {
	
	public Rigidbody2D rb;
	public int jump;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
//		if (rb.velocity.y == 0) {
			if (Input.GetButtonDown ("Jump")) {
				rb.velocity = new Vector2 (0, jump);
//			}
		}
	}
}
