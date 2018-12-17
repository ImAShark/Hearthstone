using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public GameObject EndTurnButton;

    [HideInInspector]
    public bool myTurn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (myTurn)
        {
            Debug.Log("Ben er klaar voor!");
            EndTurn();
        }
	}

    private void EndTurn()
    {
        myTurn = false;
        EndTurnButton.SendMessage("EndEnemyTurn");
    }
}
