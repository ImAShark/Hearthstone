using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour {

    public GameObject Enemy;
    
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
        }        
        
    }

}
