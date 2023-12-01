using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    left,
    down,
    right,
    up
}
public class MoveToNextRoom : MonoBehaviour
{
    public Camera thisRoomCamera;
    public Camera previousRoomCamera;
    private AudioListener thisRoomAudioListener;
    private AudioListener previousRoomAudioListener;
    public SpriteRenderer background;
    public Direction direction;
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
            if (direction == Direction.up) {
                background.transform.position = new Vector3(background.transform.position.x, background.transform.position.y + (float)(8.9783163 / 3), 2);
            }
            if (direction == Direction.down) {
                background.transform.position = new Vector3(background.transform.position.x, background.transform.position.y - (float)(8.9783163 / 3), 2);
            }
            if (direction == Direction.left) {
                background.transform.position = new Vector3(background.transform.position.x - (float)(8.9783163 / 3), background.transform.position.y, 2);
            }
            if (direction == Direction.right){
                background.transform.position = new Vector3(background.transform.position.x + (float)(8.9783163 / 3), background.transform.position.y, 2);
            }
        }
    }
}
