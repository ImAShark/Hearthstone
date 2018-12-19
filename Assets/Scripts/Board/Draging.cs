using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draging : MonoBehaviour
{
    [HideInInspector]
    public bool IsPlayer;
    public GameObject Deck;

    private GameObject UsingDeck;
    private Vector3 screenPoint;
    private Vector3 offset;

    private Camera cam;
    private bool isDragging;

    private CollisionDetectionCard colDetec;
    
    

    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        colDetec = GetComponent<CollisionDetectionCard>();
        Deck = GameObject.Find("PlayerDeck");

        if (!IsPlayer)
        {
            Destroy(this);
        }
        
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
        //Should have gone for the head!!
        if (colDetec.onBoard) {
            
            transform.position = colDetec.playPos;

            // tempCard = Deck.GetComponent<Deck>().playerHand[];
            Deck.SendMessage("OrderCards");
            gameObject.AddComponent<SpawnArrow>();
            Destroy(this);
            

        }
        else
        {
            
            transform.position = colDetec.playPos;
            
            Deck.SendMessage("OrderCards");

        }

    }
    

    

}
