using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPEnemyHero : MonoBehaviour {

    public Text EnemyHeroHP;
    private int HPStart;
    private int HP;
    


	// Use this for initialization
	void Start () {
        HPStart = 30;
        EnemyHeroHP.text = "30";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
