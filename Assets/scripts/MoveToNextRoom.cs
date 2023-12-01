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
    private int pushForce = 1;
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
            if (direction == Direction.up || direction == Direction.down) {
                background.transform.position = new Vector3(background.transform.position.x, background.transform.position.y + (float)((thisRoomCamera.transform.position.y-previousRoomCamera.transform.position.y) / 3), 2);
            }
            if (direction == Direction.left || direction == Direction.right) {
                background.transform.position = new Vector3(background.transform.position.x - (float)((thisRoomCamera.transform.position.x - previousRoomCamera.transform.position.x) / 3), background.transform.position.y, 2);
            }
        } else if (collision.gameObject.CompareTag("Box")) {
            if (direction == Direction.left) {
                collision.gameObject.transform.position = new Vector2(collision.gameObject.transform.position.x + pushForce, collision.gameObject.transform.position.y);
            }
            if (direction == Direction.right) {
                collision.gameObject.transform.position = new Vector2(collision.gameObject.transform.position.x - pushForce, collision.gameObject.transform.position.y);
            }
            if (direction == Direction.down) {
                collision.gameObject.transform.position = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y - (pushForce * 2));
            }
            if (direction == Direction.up) {
                collision.gameObject.transform.position = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + (pushForce * 2));
            }
        }
    }
}
