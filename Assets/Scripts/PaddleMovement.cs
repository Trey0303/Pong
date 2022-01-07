using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    //player movement Speed
    public int speed = 10;
    public RectTransform objectRectTransform;
    public RectTransform playerRectTransform;

    //float borderY = 0;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!Data.Paused && !Data.GameOver)
        {
            RectTransform thisRectTransform = gameObject.GetComponent<RectTransform>();

            var vel = rb.velocity;
            if (Input.GetKey(KeyCode.W))
            {
                vel.y = vel.y + speed;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                vel.y = vel.y - speed;

            }
            else
            {
                vel.y = 0;
            }
            rb.velocity = vel;

            var pos = transform.position;
            //Debug.Log(pos.y - 105);
            if (pos.y + 105  > objectRectTransform.rect.height)//top
            {
                pos.y = objectRectTransform.rect.height - 105;
            }
            else if ( pos.y - 100 < 0.01)//bot
            {
                pos.y = 105;
               //Debug.Log(playerRectTransform.rect.position.y);
            }
            //Debug.Log(playerRectTransform.rect.position.y);
            transform.position = pos;
            //Debug.Log("transformPos: " + transform.position);

        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
