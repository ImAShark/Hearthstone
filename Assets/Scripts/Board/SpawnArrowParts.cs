using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrowParts : MonoBehaviour {


    private bool _isdragging = false;
    
    private PrefabList prefabsList;
    
    // Use this for initialization
    void Start() {
        prefabsList =  GetComponent<PrefabList>();
       


    }

    // Update is called once per frame
    void Update() {
        transform.LookAt(transform.position);
        
    }

    void OnMouseDown()
    {
        Debug.Log("Hit");
        Instantiate(prefabsList.prefabs[0],transform.position, Quaternion.Euler(90, 0, 0));
        _isdragging = true;
         StartCoroutine(SpawnBlock(0.5f));
    }

    void OnMouseUp()
    {
        Destroy(GameObject.Find("ArrowTip(Clone)"));
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Block");
        foreach (GameObject gameObject in gameObjects)
        {
            GameObject.Destroy(gameObject);
        }
        _isdragging = false;
        Destroy(GameObject.Find("Target"));


    }
    public IEnumerator SpawnBlock(float WaitTime)
        {
        while (_isdragging == true)
        {
            Instantiate(prefabsList.prefabs[1], transform.position, Quaternion.Euler(90, 0, 0));
            yield return new WaitForSeconds(WaitTime);
        }
       
        

    }

}
