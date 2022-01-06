using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    //player movement Speed
    public int speed = 10;
    public RectTransform objectRectTransform;

    float borderY = 0;

    private void Start()
    {
        borderY = objectRectTransform.rect.height;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!Data.Paused)
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
            if (pos.y + 2f  > objectRectTransform.rect.height)
            {
                pos.y = borderY - 10;
            }
            else if (pos.y  < objectRectTransform.rect.height - objectRectTransform.rect.height)
            {
                pos.y = (objectRectTransform.rect.height - objectRectTransform.rect.height) + 10;
            }
            transform.position = pos;

        }
    }
}
