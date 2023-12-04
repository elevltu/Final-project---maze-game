using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody2D rb;
    private Vector2 playerPreviousLocation;
    private bool shouldMoveBack;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        
        if (shouldMoveBack) {
            rb.position = playerPreviousLocation;
            rb.velocity = Vector2.zero;
            
        }
        playerPreviousLocation = rb.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBorder")) {
            shouldMoveBack = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBorder")) {
            shouldMoveBack = false;
        }
    }
}
