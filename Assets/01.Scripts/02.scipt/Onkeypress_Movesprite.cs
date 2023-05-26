using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onkeypress_Movesprite : MonoBehaviour
{
    float vx = 0;
    float vy = 0;
    bool leftFlag = false;
    
    void Update()
    {
        vx = 0;
        vy = 0;
        if (Input.GetKey("right"))
        {
            vx = 1;
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -1;
            leftFlag = true;
        }
        if (Input.GetKey("up"))
        {
            vy = 1;            
        }
        if (Input.GetKey("down"))
        {
            vy = -1;
        }
    }
    private void FixedUpdate()
    {
        this.transform.Translate(vx / 10, vy / 10, 0);
        //this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
