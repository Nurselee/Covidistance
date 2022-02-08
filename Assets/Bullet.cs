using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;

    public int damageOfBullet = 50;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
     
    void OnTriggerEnter2D(Collider2D hitInfoCorona)
    {
        CoronaScript corona = hitInfoCorona.GetComponent<CoronaScript>();

        if(corona != null)
        {
            corona.TakeDamageForCorona(damageOfBullet);
        }
        Destroy(gameObject);
    }
    
}
