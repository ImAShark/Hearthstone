using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draging : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public Camera cam;
    private bool isDragging = false;
    private CollisionDetectionCard colDetec;
    
    

    void Start()
    {
        colDetec = GetComponent<CollisionDetectionCard>();
        
    }


    void Update()
    {
        
    }



    void OnMouseDown()
    {
        screenPoint = cam.WorldToScreenPoint(transform.position);
        offset = transform.position - cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        


    }

    void OnMouseDrag()
    {
        
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = cam.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
       
        Snap();
        
        
    }

    public bool GetDrag()
    {
        return isDragging;
    }
    public void Snap()
    {
        //SHould have gone for the head!!
        if (colDetec.onBoard) {
            
            transform.position = colDetec.playPos;
            Destroy(this);
        }
        else
        {
            
            transform.position = colDetec.playPos;
        }

    }
    

    

}
