using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsTurn : MonoBehaviour {

    public float turnAmount = 0;


    void Start()
    {
        Turn();
    }

    public void Turn()
    {
        if (transform.position.x < 0)
        {
            transform.eulerAngles = new Vector3(90,
            transform.rotation.y + 0,
            transform.rotation.z + turnAmount);
        }
        else if (transform.position.x > 0)
        {
            transform.eulerAngles = new Vector3(90,
            transform.rotation.y + 0,
            transform.rotation.z + -turnAmount);
        }
    }
}
