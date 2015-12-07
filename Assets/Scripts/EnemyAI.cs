using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    public Transform Pos;
    public bool moveR;
    public bool moveL;
    public Rigidbody2D enemy;
    public float Dis = 10;
    public float Speed = 100;
    public bool Fired;
    public GameObject Bullet;
    public Transform Player;
    public float bulletSpeed;
    // Use this for initialization
    void Start () {
        enemy = GetComponent<Rigidbody2D>();
        Fired = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        
    
	}
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            print("Trigger stay works: " + col);
            if (!Fired)
            {
                StartCoroutine(Fire());
            }
        }
    }
    IEnumerator Fire()
    {

        Fired = true;
        FireFun();
        yield return new WaitForSeconds(1);
        Fired = false;




    }
    void FireFun()
    {
        Rigidbody2D clone = Instantiate(Bullet, transform.position, Quaternion.identity) as Rigidbody2D;
        var playerDirection = Player.position - transform.position;
        clone.velocity = playerDirection.normalized * bulletSpeed * Time.deltaTime;
    }
}
