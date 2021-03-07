using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{

    public Transform[] points;
    public int speed;

    private int pointIndex;
    private float dist;

    void Start()
    {
        pointIndex = 0;
        transform.LookAt(points[pointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
       dist = Vector3.Distance(transform.position, points[pointIndex].position);

        if(dist < 1f)
        {
            AddIndex();
        }
        Patrol();
    }


    void Patrol() {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    
    }


    void AddIndex()
    {
        pointIndex++;

        if(pointIndex >= points.Length)
        {
            pointIndex = 0;
        }

        transform.LookAt(points[pointIndex].position);

    }


}
