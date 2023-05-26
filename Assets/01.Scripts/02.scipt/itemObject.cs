using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemObject : MonoBehaviour
{
    public string targetObjectName;
    private GameObject targetObject;
    private Rigidbody2D rbody;
    public float speed = 2;
    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        

    }

   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
            float vx = dir.x * speed;
            float vy = dir.y * speed;
            rbody.velocity = new Vector2(vx, vy);
            this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
        }
    }
    
}
