using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaHero : MonoBehaviour {

    //public CardTextBox kaart;

    public Text ManaText;
    
    public Mana Calculator;
    public int ManaCurrent;
    


	// Use this for initialization
	void Update () { 
        Calculator.CalculateCurrentMana();
        ManaText.text = Calculator.ManaCurrent + "/" + Calculator.ManaMax;

      
        
	}
	
}
