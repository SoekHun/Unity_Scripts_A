using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onkey_ForeverMovescrips : MonoBehaviour
{
    private enum KEY { RIGHT, LEFT, UP, DOWN }
    private KEY key = KEY.RIGHT;
    //swich case
    public float speed = 2;
    private float vx = 0;
    private float vy = 0;
    private bool leftFlag = false;
    //private bool leftFlag2 = false;
    private Rigidbody2D rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        vx = 0;
        vy = 0;
       
        
        if (Input.GetKey("right")) { key = KEY.RIGHT; }
      
       
        if (Input.GetKey("left")) { key = KEY.LEFT; }
        
        if (Input.GetKey("up")) { key = KEY.UP; }
       
        if (Input.GetKey("down")) { key = KEY.DOWN; }
        

        
    }

    private void FixedUpdate()
    {
        switch (key)
        {
            case KEY.RIGHT:
                vx = speed;
                leftFlag = false;
                break;
            case KEY.LEFT:
                vx = -speed;
                leftFlag = true;
                break;
            case KEY.UP:
                vy = speed;
                //leftFlag2 = false;
                break;
            case KEY.DOWN:
                vy = -speed;
                //leftFlag2 = true;
                break;
        }
        //�̵�ó����� 1(transform component) �ϰ����� �ӵ�
        //transform.Translate(vx/50, vy/50, 0);
        //�̵�ó����� 2(rigidboy component) �������� ���⿡ ���� ������?
        rbody.velocity = new Vector2(vx,vy);
        GetComponent<SpriteRenderer>().flipX = leftFlag;
        //GetComponent<SpriteRenderer>().flipY = leftFlag2;
    }
}
