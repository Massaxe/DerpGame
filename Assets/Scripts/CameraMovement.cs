using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public Transform player;
    public float smoothDamp = 0.2f;
    public Vector3 velocity;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerX = new Vector3(player.position.x, player.position.y, -10f);
        Vector3 movement = Vector3.SmoothDamp(transform.position, playerX, ref velocity, smoothDamp);
        transform.position = movement;

	
	}
}
