using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bezier : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public Transform point0, point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12;

    private int numPoints = 50;
    private Vector3[] positions = new Vector3[50];
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer.positionCount = numPoints;
        DrawLinearCurve();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DrawLinearCurve()
    {
        for (int i = 1; i < numPoints + 1; i++)
        {
            float t = i / (float)numPoints;
            positions[i - 1] = CalculateLinearBezierPoint(t, point0.position, point1.position,point2.position, point3.position, point4.position, point5.position, point6.position, point7.position, point8.position, point9.position, point10.position, point11.position, point12.position);
            LineRenderer.SetPositions(positions);
        }
    }
    private Vector3 CalculateLinearBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 p5, Vector3 p6, Vector3 p7, Vector3 p8, Vector3 p9, Vector3 p10, Vector3 p11, Vector3 p12)
    {
        float u = 1 - t;
        float ts = t * t;
        float us = u * u;
        Vector3 p = us * p0;
        p+= 2 * u * t * p1;
        p += ts* p2;
        return p;
    }



}
