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
        //rb.velocity = Vector2.right * speed;

        startPosition = this.transform.position;

        //transform.rotation = Quaternion.Euler(Vector3.forward * 180);

    }

    // Update is called once per frame
    void Update()
    {
        //var vel = rb.velocity;
        if (!Data.Paused && !Data.GameOver)
        {
            transform.position += transform.right * speed * Time.deltaTime;

            //Debug.Log(pos.y - 105);
            if (transform.position.x > objectRectTransform.rect.width)//right
            {
                transform.position = startPosition;
                transform.rotation = Quaternion.Euler(Vector3.forward * 0);
                Data.P1Score++;
            }
            if (transform.position.x < 0)//left
            {
                transform.position = startPosition;
                transform.rotation = Quaternion.Euler(Vector3.forward * 180);
                Data.P2Score++;
                //Debug.Log(playerRectTransform.rect.position.y);
            }
            if (transform.position.y > objectRectTransform.rect.height)//top
            {
                transform.rotation = Quaternion.Euler(Vector3.forward * Random.Range(200, 310));
                //Data.P1Score++;
            }
            if (transform.position.y < 0)//bot
            {
                transform.rotation = Quaternion.Euler(Vector3.forward * Random.Range(65, 130));
                //Data.P2Score++;
                //Debug.Log(playerRectTransform.rect.position.y);
            }
            //Debug.Log(transform.position.y);
            //transform.position = pos;
        }

    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player2")
        {
           //Debug.Log("hit P2");

            //int randAngle = Random.Range(130, 180);

            transform.rotation = Quaternion.Euler(Vector3.forward * 230);
            //rb.velocity = new Vector2(0, 0);
            //rb.velocity = Vector2.left * speed;
        }
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("hit P1");

            //transform.position = new Vector2(collision.gameObject.transform.position.x + 1, transform.position.y);
            //int randAngle = Random.Range(340, 45);

            //Debug.Log(randAngle);

            transform.rotation = Quaternion.Euler(Vector3.forward * Random.Range(5, 45));
            //rb.velocity = Vector2.right * speed * randAngle;
        }
    }
}
