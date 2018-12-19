using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPowerColllider : MonoBehaviour {

    public GameObject HeroPower;

    public void OnMouseDown()
    {
        HeroPower.SetActive(false);
        //EnemyHeroPower.text = EnemyHeroPower.text = " ";
    }
}
