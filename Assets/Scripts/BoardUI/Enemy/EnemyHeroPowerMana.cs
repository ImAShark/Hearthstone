using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHeroPowerMana : MonoBehaviour {
    public Text EnemyHeroPower;
    private int Mana;


	// Use this for initialization
	void Start () {
        Mana = 2;

        EnemyHeroPower.text = "2";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown()
    {
        EnemyHeroPower.text = EnemyHeroPower.text = " ";
    }
}
