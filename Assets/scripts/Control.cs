using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public float speed = 20f;
    public float force = 6;
    private Rigidbody2D  rb;
    private bool face = true;
    public bool isOpened = false;
    bool is_ground = false;
    private bool doublejump = false;
    public GameObject CurrProjecttile;
    public float timer;
    public float timercounter;

    void Start()
    {
        timercounter = 0;
        rb = GetComponent <Rigidbody2D>();   
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "ground") is_ground = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "ground") is_ground = false;
    }
    //поворот перса//
    void flip()
    {
        face = !face;
        transform.Rotate(0f, 180f, 0f);
    }
    void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 6f);
        rb.AddForce(Vector2.up * force);
    }
    void respawn ()
    {
        SceneManager.LoadScene("Game");
    }    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            respawn();
        }
        float moveX = Input.GetAxis ("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        if (is_ground)
        {
            doublejump = true;
        }
        if (Input.GetKeyDown(KeyCode.Z) && is_ground)
        {
            jump();
        }
        else if (doublejump && Input.GetKeyDown(KeyCode.Z))
        {
            jump();
            doublejump = false;
        }
        if (Input.GetKeyDown(KeyCode.Q) && is_ground)
        {
            SceneManager.LoadScene("Menu");
        }
        if (moveX > 0 && !face)
        {
            flip();
        }
        else if (moveX < 0 && face)
        {
            flip();
        }
        if (Input.GetKey(KeyCode.X) && timercounter <= 0)
        {
            if (CurrProjecttile && FindObjectsOfType<Projectile>().Length < 4)
            {
                Instantiate(CurrProjecttile, transform.position, transform.rotation);
                timercounter = timer;
            }
        }
        timercounter -= Time.deltaTime;
    }
}