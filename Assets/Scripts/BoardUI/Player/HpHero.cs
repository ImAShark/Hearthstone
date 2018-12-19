using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpHero : MonoBehaviour {

    public Text HeroHP;
    public int HP;
    
    

	// Use this for initialization
	void Start () {
        HP = 30;
        
        HeroHP.text = "30";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void CurrentHP()
    {


    }
}
