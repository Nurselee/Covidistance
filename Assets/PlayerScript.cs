using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator animation;
    SpriteRenderer sr;
    Rigidbody2D rigidbody2D;


    public HeartScript healthBar;
    public int maxHealthOfPlayer = 100;

    public int healthOfPlayer;
    public float restartDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {

        
        animation = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();

        healthOfPlayer = maxHealthOfPlayer;
        healthBar.SetMaxHealth(maxHealthOfPlayer);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            rigidbody2D.velocity = new Vector2(2, 0);

            animation.Play("Rogue_walk_01");


            sr.flipX = false;
        }
        else if (Input.GetKey("left") || Input.GetKey("a"))
        {
            rigidbody2D.velocity = new Vector2(-2, 0);


            animation.Play("Rogue_walk_01");

            sr.flipX = true;
        }
        else if (Input.GetKey("space"))
        {
            rigidbody2D.velocity = new Vector2(0, 0);

            animation.Play("Rogue_attack_02");
        }
        else if (Input.GetKey("up") || Input.GetKey("w"))
        {
            rigidbody2D.velocity = new Vector2(0, 3);

        }
        else
        {

            animation.Play("Rogue_idle_01");

            rigidbody2D.velocity = new Vector2(0, 0);
        }
    }

    public void TakeDamageForPlayer(int DamageOfCorona)
    {
        healthOfPlayer -= DamageOfCorona;
       
        if (healthOfPlayer <= 0)
        {
           
          
            
            FindObjectOfType<GameManager>().EndGame();
            
        }


        healthBar.SetHealth(healthOfPlayer);
    }


    public void TakeHealthFromNiddle(int HealthOfNid)
    {


        healthOfPlayer += HealthOfNid;
      
        if (healthOfPlayer <= 0)
        {
           
            
            FindObjectOfType<GameManager>().EndGame();
            
            
        }

        healthBar.SetHealth(healthOfPlayer);
    }


}
