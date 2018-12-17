using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrow : MonoBehaviour {



    private GameObject arrowTip;
    private PrefabList prefabsList;
    // Use this for initialization
    void Start() {
        prefabsList =  GetComponent<PrefabList>();
        arrowTip = prefabsList.prefabs[0];
    }

    // Update is called once per frame
    void Update() {
        transform.LookAt(transform.position);
    }

    void OnMouseDown()
    {
        Instantiate(arrowTip,transform.position, Quaternion.Euler(90, 0, 0));
    }
    void OnMouseUp()
    {
        
    }

}
