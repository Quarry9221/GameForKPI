using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool ToBe = false; 
    private bool pause = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Boshy"))
        {
            Time.timeScale = 0;
            pause = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
