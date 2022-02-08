using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiddleScript : MonoBehaviour
{
    [SerializeField]
    Transform player;

    Rigidbody2D rb2d;

    public int HealthOfNid = 25;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D hitInfoPlayerN)
    {
        PlayerScript playerN = hitInfoPlayerN.GetComponent<PlayerScript>();

        if (playerN != null)
        {

            playerN.TakeHealthFromNiddle(HealthOfNid);
            Destroy(gameObject);

        }
    }
}
