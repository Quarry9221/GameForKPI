using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerNextLevel : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {
            SceneManager.LoadScene("lvl_2");
        }
    }
}
