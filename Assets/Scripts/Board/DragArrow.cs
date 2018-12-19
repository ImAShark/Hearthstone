using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragArrow : MonoBehaviour {
    
    private Vector3 offset;

    private Camera _cam;
    public Vector3 testVector;
    public float rotation;
    public Vector3 rotPot;
    public Vector3 tipFollow;
   

    
    
    // Use this for initialization
    void Start () {

        _cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 A = _cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 B = transform.position;
        Vector3 C = new Vector3(A.x, 0, B.z);

        
        //arrow rotation
             rotation = Mathf.Atan2(-A.x, A.z) * Mathf.Rad2Deg;

             rotPot = new Vector3(90, 0, rotation);

            transform.rotation = Quaternion.Euler(rotPot);

            tipFollow = new Vector3(A.x, 0, A.z);
            transform.position = tipFollow;
        



    }

}
