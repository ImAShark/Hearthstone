using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour {

    public GameObject Enemy;
    public GameObject PlayerDeck;
    public GameObject EnemyDeck;
    
    public Sprite Button1;
    public Sprite Button2;
    public Button EndButton;

    [HideInInspector]
    public bool playerTurn = true;

    public void EndThisTurn()
    {
        if (playerTurn)
        {
            playerTurn = false;
            EndButton.image.sprite = Button2;
            Enemy.GetComponent<EnemyAI>().myTurn = true;
            EnemyDeck.SendMessage("DrawCard", 1);
            EnemyDeck.SendMessage("OrderCards");
        }        
        
    }

    public void EndEnemyTurn()
    {
        if (!playerTurn)
        {
            playerTurn = true;
            EndButton.image.sprite = Button1;
            PlayerDeck.SendMessage("DrawCard", 1);
            PlayerDeck.SendMessage("OrderCards");
        }
    }

}
