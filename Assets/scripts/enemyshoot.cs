using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public GameObject projectile;
    public GameObject dulo;

    public float shootdelay = 1.5f;
    private float shootdelaycounter;
    public float delay = 0.3f;
    private float delaycounter;
    public void Update()
    {
        if (shootdelaycounter <= 0)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            shootdelaycounter = shootdelay;
        }
        shootdelaycounter -= Time.deltaTime;
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
