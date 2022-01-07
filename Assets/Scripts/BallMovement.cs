using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 100;

    public Transform originalObject;
    public Transform reflectedObject;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //var vel = rb.velocity;
        if (!Data.Paused)
        {
            //rb.velocity;
            //move ball horozontally
            //vel = Vector2.right * speed;

        }
        else
        {
            rb.velocity = new Vector2(0, 0);

            //vel = new Vector2(0, 0);
        }
        //rb.velocity = vel;

        

    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player2")
        {
            Debug.Log("hit P2");
            transform.rotation = Quaternion.Euler(Vector3.forward * 15);
            //rb.velocity = new Vector2(0, 0);
            rb.velocity = Vector2.left * speed;
        }
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit P1");
            rb.velocity = Vector2.right * speed;
        }
    }
}
