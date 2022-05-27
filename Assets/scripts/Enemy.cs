using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public float delay = 10;
    public float delaycounter;
    public float direction = -1f;
    private int time = 10;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        while (time >= 0)
        {
            if (delay <= 10 && delay > 5)
            {
                rb.velocity = new Vector2(speed * direction, rb.velocity.y);
                delaycounter = delay;
            }
            if (delay <= 5 && delay >= 0)
            {
                direction = 1f;
                rb.velocity = new Vector2(speed * direction, rb.velocity.y);
            }
            delaycounter -= Time.time;
            time = 10;
        }
    }
}
