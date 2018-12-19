using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour {

    public Transform target;
    public float speed;
    private GameObject _arrow;
    private Vector3 rotation;
    
	// Use this for initialization
	void Start () {
        _arrow = GameObject.Find("ArrowTip(Clone)");
        target = _arrow.transform;
        
    }
	
	// Update is called once per frame
	void Update () {
        rotation = _arrow.GetComponent<DragArrow>().rotPot;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.rotation = Quaternion.Euler(rotation);
        if(transform.position == target.position)
        {
            Destroy(gameObject);
        }
    }
}
