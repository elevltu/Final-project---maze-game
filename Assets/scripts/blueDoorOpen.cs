using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueDoorOpen : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerKeys.blueKeys >= 1)
        {
            PlayerKeys.blueKeys--;
            Destroy(rb);
        }
    }
}
