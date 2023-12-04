using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBoxForRoom : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 startingLocation;
    // Start is called before the first frame update
    void Start()
    {
        startingLocation = rb.position;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.position = startingLocation;
            rb.velocity = Vector2.zero;
        }
    }
}
