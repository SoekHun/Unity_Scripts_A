using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveH_OnCollision_Flip : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    
    void Update()
    {
        rbody.velocity = new Vector2 (speed, 0); //Vector(x,y) Vector3(x,y,z)

    }

    private void OnCollisionEnter2D(Collision2D collision) //Add(int a)
    {
        //Destroy(collision.gameObject); // 게임오브젝트를 없앨때
        speed = -speed;
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);
    }
}
