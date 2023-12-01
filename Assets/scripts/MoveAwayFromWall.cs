using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAwayFromWall : MonoBehaviour
{
    public int pushForce = 1;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("WallLeft"))
        {
            rb.position = new Vector2(rb.position.x+pushForce, rb.position.y);
        }
        if (collision.gameObject.CompareTag("WallRight"))
        {
            rb.position = new Vector2(rb.position.x-pushForce, rb.position.y);
        }
        if (collision.gameObject.CompareTag("WallTop"))
        {
            rb.position = new Vector2(rb.position.x, rb.position.y-(pushForce*2));
        }
        if (collision.gameObject.CompareTag("WallBottom"))
        {
            rb.position = new Vector2(rb.position.x, rb.position.y+(pushForce*2));
        }
        print(collision.collider);
    }
    
}
