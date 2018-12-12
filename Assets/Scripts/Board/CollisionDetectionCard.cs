using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionCard : MonoBehaviour {
    
    private Vector3 basePos = new Vector3(0.07f, 9.48f, -4.07f);
    private Vector3 cardPos = new Vector3(0f, 9.48f, 0.73f);
    public Vector3 playPos;
    public bool onBoard = false;
    // Use this for initialization
    void Start () {
        playPos = basePos;

        
	}

    void OnTriggerEnter(Collider other)
    {
       
            onBoard = true;
            playPos = cardPos;
      
            
    }
    private void OnTriggerExit(Collider other)
    {
        onBoard = false;
        playPos = basePos;
      
    }

 


  

}
