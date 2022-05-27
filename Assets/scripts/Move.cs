using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed = 7f;
	void Update()
	{
		rb.velocity = transform.right * speed;
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
