using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnKeyPress_MoveGravity : MonoBehaviour
{

    float jumpPower = 5f;
    [SerializeField] float jumpCount;
    bool groundFlag = false;
    bool pushFlag = false;
    bool jumpFlag = false;
    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    
    void Update()
    {
        Move();


        if(Input.GetKeyDown(KeyCode.Space) && !pushFlag && !jumpFlag) 
        {
            rbody.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            jumpCount--;
            jumpFlag = false;
            if(jumpCount <= 0)
            {
                jumpPower = 0;
            }
        }
    }
    void FixedUpdate()
    {
        if (jumpFlag)
        {         
            rbody.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            jumpFlag = false;

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        jumpCount = 1;
        jumpPower = 5f;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        groundFlag = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        groundFlag = false;
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 3f;
        transform.Translate(x, 0f, 0f);

        if (Input.GetKey(KeyCode.Space) && groundFlag)
        {
            if (pushFlag == false)
            {
                jumpFlag = true;
                pushFlag = true;
            }
        }
        else
        {
            pushFlag = false;
        }
    }

}
