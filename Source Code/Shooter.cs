using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public float ballSpeed;

    private Rigidbody2D theRB;

    public GameObject ballEffect;

	// Use this for initialization
	void Start () {
        theRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        theRB.velocity = new Vector2(ballSpeed * transform.localScale.x, 0);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Buddy")
        {
            FindObjectOfType<GameManager>().HurtP1();
        }
        if (other.tag == "Stela")
        {
            FindObjectOfType<GameManager>().HurtP2();
        }

        Instantiate(ballEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
