using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rd;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        rd.AddRelativeForce(Vector2.right * speed,  ForceMode2D.Impulse);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
