using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curving : MonoBehaviour {
    public Text textBox;

    public LineRenderer lineRenderer;
    public Transform point0, point1, point2, point3;

    private int numPoints = 50;
    private Vector3[] positions = new Vector3[50];


	// Use this for initialization
	void Start () {
        lineRenderer.positionCount = numPoints;

        drawCubicCurve();   
	}
	
	  //Update is called once per frame
	void Update () {
        drawCubicCurve();
    }

    private void drawCubicCurve()
    {
        for(int i = 1; i < numPoints + 1; i++)
        {
            float t = i / (float)numPoints;
            positions[i - 1] = CalculateCubicCurve(t, point0.position, point1.position, point2.position, point3.position);
        }
        lineRenderer.SetPositions(positions);
    }

    private Vector3 CalculateCubicCurve(float t, Vector3 p0, Vector3 p1,Vector3 p2, Vector3 p3)
    {
        //B(t) = (1-t)3P0 + 3(1-t)2tP1 + 3(1-t)t2P2 + t3P3
        //return = uuu *p0+ 3*uu* t*p1 + 3*u*tt*p2 ttt       


        float u = 1 - t;
        float tt = t * t;
        float ttt = t * t* t;
        float uu = u * u;
        float uuu = uu * u;
        Vector3 p = uuu * p0;
        p += 3 * uu * t * p1;
        p += 3 * u * tt * p2;
        p += ttt * p3;


        return p;
    }

}
