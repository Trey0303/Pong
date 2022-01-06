using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb.velocity;
        if (!Data.Paused)
        {
            //move ball horozontally
            vel = new Vector2(speed, 0);

        }
        else
        {
            vel = new Vector2(0, 0);
        }
        rb.velocity = vel;



    }
}
