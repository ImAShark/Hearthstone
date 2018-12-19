using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour {

    public int ManaStart = 0;
    public int ManaMax = 10;
    public int ManaCurrent;
    public int AddMana = 1;


    public void CalculateCurrentMana()
    {
        ManaCurrent = ManaStart + AddMana;
        Debug.Log(ManaCurrent);
    }

    public void OnMouseDown()
    {
        ManaCurrent = ManaCurrent + AddMana;
        Debug.Log(ManaCurrent);
    }
}
