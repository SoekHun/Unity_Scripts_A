using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float EnemyHP = 3.0f;
    private float speed = 1f;
    Transform playerTr;
    newThrow player;
    void Start()
    {
        playerTr = GameObject.FindWithTag("Player").GetComponent<Transform>();
        player = GameObject.FindWithTag("Player").GetComponent<newThrow>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerTr.position, Time.deltaTime * speed);
        //transform.Rotate(Vector3.forward * speed, Time.deltaTime * 200.0f);  
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("EnemyHP" + EnemyHP);
            EnemyHP -= 1f;

        }
        if(EnemyHP < 0.0f)
        {
            Debug.Log("사망" + EnemyHP);
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("플레이어와 충돌");
            Destroy(this.gameObject);

        }
    }
}
