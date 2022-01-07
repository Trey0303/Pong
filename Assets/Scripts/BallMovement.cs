using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 100;

    public Transform originalObject;
    public Transform reflectedObject;

    public RectTransform objectRectTransform;
    private Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.right * speed;

        startPosition = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //var vel = rb.velocity;
        if (!Data.Paused && !Data.GameOver)
        {
            if (rb.velocity == new Vector2(0,0))
            {
                rb.velocity = Vector2.right * speed;
            }

            var pos = transform.position;
            //Debug.Log(pos.y - 105);
            if (pos.x > objectRectTransform.rect.width)//right
            {
                pos = startPosition;
                Data.P1Score++;
            }
            else if (pos.x < 0.01)//left
            {
                pos = startPosition;
                Data.P2Score++;
                //Debug.Log(playerRectTransform.rect.position.y);
            }
            //Debug.Log(playerRectTransform.rect.position.y);
            transform.position = pos;
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
