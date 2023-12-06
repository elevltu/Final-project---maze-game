using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueDoorOpen : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip openClip;
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
        if (collision.gameObject.CompareTag("Player") && PlayerKeys.blueKeys >= 1)
        {
            gameObject.SetActive(false);
            PlayerKeys.blueKeys--;
            AudioSource.PlayClipAtPoint(openClip, transform.position);
        }
    }
}
