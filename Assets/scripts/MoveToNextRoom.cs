using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNextRoom : MonoBehaviour
{
    public Camera thisRoomCamera;
    public Camera previousRoomCamera;
    private AudioListener thisRoomAudioListener;
    private AudioListener previousRoomAudioListener;
    // Start is called before the first frame update
    private void Start()
    {
        thisRoomAudioListener = thisRoomCamera.GetComponent<AudioListener>();
        previousRoomAudioListener = previousRoomCamera.GetComponent<AudioListener>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !thisRoomCamera.enabled)
        {
            thisRoomCamera.enabled = true;
            previousRoomCamera.enabled = false;
            thisRoomAudioListener.enabled = true;
            previousRoomAudioListener.enabled = false;
        }
    }
}
