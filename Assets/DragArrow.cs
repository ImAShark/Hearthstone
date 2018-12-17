using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragArrow : MonoBehaviour {
    private Vector3 mousePoint;
    private Vector3 offset;
    private Camera cam;
    
    
    // Use this for initialization
    void Start () {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        
    }
	
	// Update is called once per frame
	void Update () {
        
        mousePoint = cam.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePoint);


        transform.LookAt(mousePoint);
        

    }

}
