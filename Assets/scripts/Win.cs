using UnityEngine.SceneManagement;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
