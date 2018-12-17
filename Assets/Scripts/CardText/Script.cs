using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour{

    public CardTextBox kaart;

    public Text nameText;
    public Text descriptionText;

    //public Image charFoto;

    public Text manaText;
    public Text attackText;
    public Text healthText;

	// Use this for initialization
	void Start () {

        nameText.text = kaart.nameBox;
        descriptionText.text = kaart.description;

        //charFoto.sprite = kaart.charArt;

        manaText.text = kaart.manaCost.ToString();
        attackText.text = kaart.attackDamage.ToString();
        healthText.text = kaart.healthPoints.ToString();


    }

    void ParseData(CardTextBox card)
    {
        nameText.text = kaart.nameBox;
        descriptionText.text = kaart.description;

        //charFoto.sprite = kaart.charArt;

        manaText.text = kaart.manaCost.ToString();
        attackText.text = kaart.attackDamage.ToString();
        healthText.text = kaart.healthPoints.ToString();
    }


   


}
