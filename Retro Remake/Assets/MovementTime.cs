using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTime : MonoBehaviour
{
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;
    public float speed = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Left))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }

        if (Input.GetKey(Right)) 
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
       
        if (Input.GetKey(Up)) 
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        if (Input.GetKey(Down)) 
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
        }

    }
}
