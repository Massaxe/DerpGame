using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    public Transform firstPos;
    public Transform secondPos;
    public bool moveFP;
    public bool moveSP;
    public Rigidbody2D enemy;
    // Use this for initialization
    void Start () {
        enemy = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 firstPosV = new Vector2(firstPos.position.x, transform.position.y);
        if (moveFP)
        {
            Vector2 mf = Vector2.MoveTowards(transform.position, firstPosV, 10);
            enemy.velocity += mf * 50 * Time.deltaTime;
        }
	
    
	}
}
