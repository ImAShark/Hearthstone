using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaEnemyHero : MonoBehaviour {

    public Text EnemyHeroMana;

    public GameObject Mana;
    private Mana Calculator;
    public int ManaCurrent;
    


	
	// Update is called once per frame
	void Update () {
        Calculator = Mana.GetComponent<Mana>();
        Calculator.CalculateCurrentMana();
        EnemyHeroMana.text = Calculator.ManaCurrent + "/" + Calculator.ManaMax;
		
	}
}
