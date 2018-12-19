using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public int drawAmount = 3;
    public float curvePos = 0;
    public float curveHeigth = 0;
    public float lowering = 0;
    public float strength = 0;
    private int cardsInHand = 0;

    public bool IsplayerDeck = true;

    public Vector3 spawn = new Vector3(0, 0, 0);

    private Quaternion rot;

    public List<GameObject> playerDeck = new List<GameObject>();
    public List<GameObject> playerHand = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < playerDeck.Count; i++)
        {
            playerDeck[i].GetComponent<Draging>().IsPlayer = IsplayerDeck;
        }

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
                    GameObject obj = Instantiate(playerDeck[random], spawn, Quaternion.Euler(90, 0, 0));
                    playerHand[cardsInHand] = obj;
                    playerDeck.RemoveAt(random);
                    cardsInHand++;
                }
            }
        }
        OrderCards();
    }

    private void OrderCards()
    {
        //curvePos = curvePos - (4 * cardsInHand);
        for (int i = 0; i < cardsInHand; i++)
        {
            Vector3 pos = new Vector3(
                i,
                0,
                //Mathf.Sin(((i * Mathf.PI) - curvePos -4) / (playerHand.Count - 1)) * curveHeigth
                0);
            playerHand[i].transform.position = pos;

            Vector3 pos2 = new Vector3(playerHand[i].transform.position.x - (cardsInHand/2.4f),
            playerHand[i].transform.position.y,
            playerHand[i].transform.position.z - lowering);

            playerHand[i].transform.position = pos2;

          /*  for (int j = -(cardsInHand / 2); j < cardsInHand / 2; j++)
            {
                //int temp = j * 2;
                Quaternion.Euler(playerHand[i].transform.rotation.x, 
                playerHand[i].transform.rotation.y, 
                playerHand[i].transform.rotation.z * (j * strength));

            }*/
        }


        
    }
}