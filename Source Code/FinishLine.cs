using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public bool P1Flag;
    public bool P2Flag;

    public GameObject p1Wins;
    public GameObject p2Wins;
    public GameObject draw;

    public Transform P1flagCheckPoint;
    public Transform P2flagCheckPoint;
    public float flagCheckRadius;
    public LayerMask whatIsFlagLine;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        P1Flag = Physics2D.OverlapCircle(P1flagCheckPoint.position, flagCheckRadius, whatIsFlagLine);
        P2Flag = Physics2D.OverlapCircle(P2flagCheckPoint.position, flagCheckRadius, whatIsFlagLine);
        
        if ((P1Flag == true)  && (P2Flag == true))
        {
            player1.SetActive(false);
            player2.SetActive(false);
            draw.SetActive(true);
        }
        else if ((P1Flag == true) && (P2Flag == false))
        {
            player2.SetActive(false);
            p1Wins.SetActive(true);
        }
        else if ((P1Flag == false) && (P2Flag == true))
        {
            player1.SetActive(false);
            p2Wins.SetActive(true);
        }
        
    }
}
