 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HittingText : MonoBehaviour {

    public Text HitTextBox;
    public int DamageFace;
    private string DamageToText;

    private void Update()
    {
        OnHeroHit();
    }

    public void OnHeroHit()
    {
        if(DamageFace > 0)
        {
            DamageToText = DamageFace.ToString();
            Debug.Log(DamageToText);
            HitTextBox.text = "-" +DamageToText;
        }
    }

}
