using UnityEngine;

public class moveenemy : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed = 7f;
	void Update()
	{
		rb.velocity = (transform.right * - 1) * speed;
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
