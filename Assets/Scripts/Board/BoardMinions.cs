using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMinions : MonoBehaviour {

    public List<GameObject> PlayerBoard = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void KillMinion(int m)
    {
        PlayerBoard[m] = null;
    }
}
