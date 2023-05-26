using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Roulette : MonoBehaviour
{
    public float maxSpeed = 0;
    public float Speed = 0;
    void Start()
    {
        Speed = maxSpeed;
    }

    
    void Update()
    {
        Speed = Speed * (float)0.97;
        this.transform.Rotate(0, 0, Speed);
    }
}
