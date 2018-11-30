using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPlayer : MonoBehaviour
{

    public List<GameObject> playerDeck = new List<GameObject>();
    public List<GameObject> playerHand = new List<GameObject>();

    public Vector3 spawn = new Vector3(0, 0, 0);

    private int cardsInHand = 0;

    // Use this for initialization
    void Start()
    {
        DrawCard(3);
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

                    Instantiate(playerDeck[random], spawn, Quaternion.identity);
                    playerDeck.RemoveAt(random);
                    cardsInHand++;

                }
            }
        }
    }
}

