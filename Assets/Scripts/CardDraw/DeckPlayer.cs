﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPlayer : MonoBehaviour
{
    public int drawAmount = 3;
    public float curvePos = 0;
    public float lowering = 0;
    private int cardsInHand = 0;

    public Vector3 spawn = new Vector3(0, 0, 0);



    public List<GameObject> playerDeck = new List<GameObject>();
    public List<GameObject> playerHand = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        DrawCard(drawAmount);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DrawCard(int amount)
    {
        for (int i = 0; i < amount; i++)
        {

            {
                int random = Random.Range(0, playerDeck.Count);
                //Debug.Log(playerDeck[random]);
                //Debug.Log(playerDeck.Count + " count");

                if (playerDeck.Count == 0)
                {
                    Debug.Log("oof de hero");
                    //deal damage
                }
                else if (playerHand[9] != null)
                {
                    playerDeck.RemoveAt(random);
                    Debug.Log("Card " + random + " discarted");
                }
                else
                {
                    playerHand[cardsInHand] = playerDeck[random];

                    GameObject obj = Instantiate(playerDeck[random], spawn, Quaternion.Euler(90, 0, 0));
                    playerHand[i] = obj;

                    playerDeck.RemoveAt(random);
                    cardsInHand++;
                }
            }
        }
        OrderCards();
    }

    private void OrderCards()
    {
        for (int i = 0; i < cardsInHand; i++)
        {
            Vector3 pos = new Vector3(
            i - 1,
            0,
            Mathf.Sin(((i * Mathf.PI) - curvePos) / (playerHand.Count - 1)) * 2f
            );
            playerHand[i].transform.position = pos;
            Vector3 pos2 = new Vector3(playerHand[i].transform.position.x - 1,
            playerHand[i].transform.position.y, playerHand[i].transform.position.z - lowering);
            playerHand[i].transform.position = pos2;
        }
    }
}