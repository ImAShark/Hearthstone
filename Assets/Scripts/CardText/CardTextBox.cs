using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName ="Nieuwe kaart", menuName ="Kaart")]
public class CardTextBox : ScriptableObject {

    public string nameBox;
    public string description;

    //public Sprite charArt;
    

    public int manaCost;
    public int attackDamage;
    public int healthPoints;
}
