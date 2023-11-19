using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActivation : MonoBehaviour
{
    public GameObject keyToBeActivated;
    private bool keyIsActive;
    // Start is called before the first frame update
    void Start()
    {
        keyIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box") && !keyIsActive)
        {
            keyToBeActivated.SetActive(true);
            keyIsActive = true;
        }
    }
}
