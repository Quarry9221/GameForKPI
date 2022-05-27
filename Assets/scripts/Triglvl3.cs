using UnityEngine.SceneManagement;
using UnityEngine;

public class Triglvl3 : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {
            SceneManager.LoadScene("lvl_3");
        }
    }
}