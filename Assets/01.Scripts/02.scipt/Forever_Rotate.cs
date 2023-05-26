using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_Rotate : MonoBehaviour
{
    public float angle = 90;

    void FixedUpdate()
    {
        transform.Rotate(0, 0, 50/ angle);    
    }
}
