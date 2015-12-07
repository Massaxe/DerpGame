using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public Rigidbody2D player;
    public float movementSpeed;
	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
    void FixedUpdate ()
    {
        float axisX = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(axisX, 0f);
        player.velocity += movement * movementSpeed * Time.deltaTime;
        
    }
}
