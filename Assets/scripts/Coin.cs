using UnityEngine.SceneManagement;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {
            Score.score++;
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {
            SceneManager.LoadScene("lvl_3");
        }
    }
}
