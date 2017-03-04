using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHurt : MonoBehaviour {

    /*public GameObject player1;
    public GameObject player2;

    public bool P1Spike;
    public bool P2Spike;

    public Transform P1spikeCheckPoint;
    public Transform P2spikeCheckPoint;
    public float spikeCheckRadius;
    public LayerMask whatIsSpike;*/

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update ()
    {
       // StartCoroutine(count());
        /*
        P1Spike = Physics2D.OverlapCircle(P1spikeCheckPoint.position, spikeCheckRadius, whatIsSpike);
        P2Spike = Physics2D.OverlapCircle(P2spikeCheckPoint.position, spikeCheckRadius, whatIsSpike);

        if (P1Spike)
        {
            
            FindObjectOfType<GameManager>().HurtP1();
                
        }
        if (P2Spike)
        {
            FindObjectOfType<GameManager>().HurtP2();
        }*/
    }
    /*
        IEnumerator count()
        {
            //yield return new WaitForSeconds(1);
            P1Spike = Physics2D.OverlapCircle(P1spikeCheckPoint.position, spikeCheckRadius, whatIsSpike);
            P2Spike = Physics2D.OverlapCircle(P2spikeCheckPoint.position, spikeCheckRadius, whatIsSpike);

            while (P1Spike)
            {
                yield return new WaitForSeconds(1);
                FindObjectOfType<GameManager>().HurtP1();
                println("");
                yield return new WaitForSeconds(1);
                break;
            }
            if (P2Spike)
            {
                FindObjectOfType<GameManager>().HurtP2();
            }
            //yield return new WaitForSeconds(100);
        }*/

    //  IEnumerator 
    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.tag == "Buddy")
        {
            */if (other.tag == "Buddy")
            {
                for (int i=0; i<2; i++)
                {
                    FindObjectOfType<GameManager>().HurtP1();
                    yield return new WaitForSeconds(1);
                }
                
            }/*
            FindObjectOfType<GameManager>().HurtP1();
            FindObjectOfType<GameManager>().HurtP1();*/

        //}
        if (other.tag == "Stela")
        {
            for (int i = 0; i < 2; i++)
            {
                FindObjectOfType<GameManager>().HurtP2();
                yield return new WaitForSeconds(1);
            }
        }
    }
}
