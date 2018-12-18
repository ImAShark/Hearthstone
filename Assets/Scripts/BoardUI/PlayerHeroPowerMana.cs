using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeroPowerMana : MonoBehaviour {
    public Text HeroPowerMana;
    private int Mana;


	// Use this for initialization
	void Start () {
        Mana = 2;

        HeroPowerMana.text = "2";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        
    }
}
