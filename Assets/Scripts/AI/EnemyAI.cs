using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public GameObject EndTurnButton;
    public GameObject MyDeck;

    public float heigth = 0;

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
            SelectCard();


            EndTurn();
        }
	}

    private void SelectCard()
    {
        Debug.Log("YEET!");
        int mana = 1;// gameObject.GetComponent<Mana>().manaCurrent;

        if (mana > 0)
        {
            PlayMinionCard(MyDeck.GetComponent<Deck>().playerHand[1]);
            //MyDeck.SendMessage("OrderCards");
        }
    }

    private void PlayMinionCard(GameObject card)
    {
        Debug.Log(card);
        Vector3 pos = new Vector3(0,0,heigth);
        card.transform.position = pos;
    }


    private void EndTurn()
    {
        myTurn = false;
        EndTurnButton.SendMessage("EndEnemyTurn");
    }
}
