using UnityEngine;
using UnityEngine.SceneManagement;

public class Traps : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    float direction = -1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {

            rb.isKinematic = false;
            rb.velocity = new Vector2(rb.velocity.x, speed * direction);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {
            SceneManager.LoadScene("Die");
        }
    }

}
