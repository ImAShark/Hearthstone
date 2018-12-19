using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBackgroundDeck : MonoBehaviour {

    public GameObject Achtergrond;
    public Sprite Background;

    public Text Deck;
    public int KaartInDeck;
    public string Spelling;

	// Use this for initialization
	void Start () {
        Achtergrond.GetComponent<SpriteRenderer>().sprite = Background;

        KaartInDeck = 26;
        SpellingControle();
        Deck.text = "You have " + KaartInDeck + " " + Spelling +" in your deck left";
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpellingControle()
    {
        Spelling = "cards";
        if (KaartInDeck < 2 && KaartInDeck > 0)
        {
            Spelling = "card";
        }
        else if (KaartInDeck < 0)
        {
            Spelling = "cards";
        }
    }
}
