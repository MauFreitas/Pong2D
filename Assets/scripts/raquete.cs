using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raquete : MonoBehaviour
{
    public float speed;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "p1")
        {
            float moveY = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x,Mathf.Clamp(transform.position.y+ moveY,minY,maxY));

        }else if(gameObject.name == "p2")
        {
            float moveY = Input.GetAxisRaw("Vertical1") * speed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y + moveY, minY, maxY));

        }
    }
    
}
