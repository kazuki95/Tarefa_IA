using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
   
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(5,0,0), Time.deltaTime);        
    }
}

