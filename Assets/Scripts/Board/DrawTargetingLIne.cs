using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTargetingLIne : MonoBehaviour {



    public Camera cam;
    public Material lineMaterial;
    public float lineWidth;
    public float depth;
    private Vector3? lineSTartPosition = null;

	// Use this for initialization
	void Start () {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        lineSTartPosition = transform.position;
    }
    private void OnMouseUp()
    {
        lineSTartPosition = null;
    }


    private Vector3 GetMouseTOScreenPoint()
    {
        var ray =  cam.ScreenPointToRay(Input.mousePosition);
        return ray.origin + ray.direction * depth;
    }

}
