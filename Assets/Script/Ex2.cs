using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(5, 2, 0), Time.deltaTime);
    }
}
