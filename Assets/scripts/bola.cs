using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public float speed;
    Vector2 direction;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("parede"))
        {
            direction.y = -direction.y;
        }else if (collision.gameObject.CompareTag("raquete"))
        {
            speed = speed + Random.Range(0.9f, 2f);
            direction.x = -direction.x;
        }
    }
    private void Update()
    {
        if (this.transform.position.x >= 8.9f)
        {
            this.transform.position = new Vector2(0f, 0f);
            speed = 5;
        }if(this.transform.position.x <= -8.9)
        {
            this.transform.position = new Vector2(0f, 0f);
            speed = 5;
        }
    }
}
