using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallauto_Move : MonoBehaviour
{
    public float rightMax = 100.0f;
    public float leftMax = -100.0f;
    public float currentX;
    public float direction = 10.0f;
    void Start()
    {
        currentX = transform.position.x;
        
    }

    void Update()
    {
        currentX += Time.deltaTime * direction;
        if(currentX > rightMax) 
        {
            currentX = rightMax;
            direction *= -1; // 왼쪽 방향
        }
        else if(currentX < leftMax) 
        {
            currentX = leftMax;
            direction *= -1; //오른쪽 방향
        }
        transform.position = new Vector2(currentX, -2);

    }
}
