using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(speed * Time.deltaTime, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(new Vector2(-speed * Time.deltaTime, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector2(0, speed * Time.deltaTime), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector2(0, -speed * Time.deltaTime), ForceMode.Impulse);
        }
    }
}
