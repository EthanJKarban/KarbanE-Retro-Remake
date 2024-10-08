using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTime : MonoBehaviour
{
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;
    public KeyCode jump = KeyCode.W;
    public float speed = 3, jumpHeight = 15, maxSpeed = 10;
    
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            // Input.GetKey() is for HOLDING a key
            // Input.GetKeyDown() is for PRESSING a key
            // Input.GetKeyUp() is for releasing

        if (Input.GetKey(Left))     // Check for the player HOLDING DOWN the left button
        {
            // Get the GameObject's Rigidbody2D component and set its velocity to the left at the given speed
          
            _rb.AddForce(Vector2.left * speed * Time.deltaTime);
            //  _rb.velocity = Vector2.left * speed;
        }

        if (Input.GetKey(Right))    // Check for the player HOLDING DOWN the right button
        {
            // Get the GameObject's Rigidbody2D component and set its velocity to the Right at the given speed
            _rb.AddForce(Vector2.right * speed * Time.deltaTime);
            // _rb.velocity = Vector2.right * speed;
        }

        if (Input.GetKey(Up))   // Check for the player HOLDING DOWN the up button
        {
            // Get the GameObject's Rigidbody2D component and set its velocity to the up at the given speed
            _rb.AddForce(Vector2.up * speed * Time.deltaTime);
            // _rb.velocity = Vector2.up * speed;
        }
        if (Input.GetKey(Down))     // Check for the player HOLDING DOWN the down button
        {
            // Get the GameObject's Rigidbody2D component and set its velocity to the down at the given speed
            _rb.AddForce(Vector2.down * speed * Time.deltaTime);
            //_rb.velocity = Vector2.down * speed;
        }

        if (_rb.velocity.x >  maxSpeed)
            _rb.velocity = new Vector2(maxSpeed, _rb.velocity.y);
        if (_rb.velocity.x >  -maxSpeed)
            _rb.velocity = new Vector2(maxSpeed, _rb.velocity.y);
        {
            
        }

        if (Input.GetKey(jump))   // Check for the player PRESSING the jump button
        {
            // Get the Gameobject's Rigidbody 2D component and set its velocity to be to the up at given jump height
            _rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            //_rb.velocity = Vector2.up * jumpHeight;
        }


    }

    


 }
