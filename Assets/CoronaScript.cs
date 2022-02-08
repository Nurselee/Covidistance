using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaScript : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float SocialDistance;

    [SerializeField]
    float moveSpeed;


    Rigidbody2D rb;


    public int healthOfCorona = 100;

    public int DamageOfCorona = 25;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        print("distToPlayer: "+ distToPlayer);

        if(distToPlayer < SocialDistance)
        {
            ChasePlayer();
        }

        else
        {
            StopChasingPlayer();
        }
    }


    public void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(moveSpeed, 0);
        }

        else if(transform.position.x > player.position.x)
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
        }
    }

    public void StopChasingPlayer()
    {
        rb.velocity = new Vector2(0,0);
    }



    public void TakeDamageForCorona(int damageOfBullet)
    {
        healthOfCorona -= damageOfBullet;
        if(healthOfCorona <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfoPlayer)
    {
        PlayerScript player = hitInfoPlayer.GetComponent<PlayerScript>();

        if (player != null) {

            player.TakeDamageForPlayer(DamageOfCorona);
        
        }
    }
  
}
