using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour
{
    public string keyColor;
    private bool isActive = true;
    public AudioClip keyClip;
    private AudioSource audioSource;
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
        if (isActive == true && keyColor == "blue")
        {
            PlayerKeys.blueKeys++;
            AudioSource.PlayClipAtPoint(keyClip, transform.position);
            gameObject.SetActive(false);
            isActive = false;
        }
    }
}
