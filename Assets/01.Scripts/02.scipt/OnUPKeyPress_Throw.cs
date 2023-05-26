using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnUPKeyPress_Throw : MonoBehaviour
{
    public GameObject newPrefab; //인스펙ㅌㅓ 창ㅇㅔ 직ㅈㅓㅂ 넣ㅇㅓㄹㅏ
    public int maxCount;
    public float throwX = 4;
    public float throwY = 8;
    public float offsetY = 1;

    bool pushFlag = false; //up키가 눌ㄹㅕㅆㄲ느지 안ㄴㅜㄹ렸ㄴㅡㅈ
    bool leftFlag = false;
 

    void Update()
    {
        if(Input.GetKey("right"))
        {
            leftFlag = false;
        }
        if(Input.GetKey("left"))
        {
            leftFlag = true;
        }
        if(Input.GetKey(KeyCode.Space))
        {
            if(pushFlag == false)
            {
                pushFlag = true;
                Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
                Vector3 newpos = this.transform.position;
                newpos.y += offsetY;


                GameObject newGameObject = GameObject.Instantiate(newPrefab) as GameObject;
                newpos.z = -5;
                newGameObject.transform.position = newpos;
                Rigidbody2D rbody = newGameObject.GetComponent<Rigidbody2D>();
                //if(leftFlag)
                //{
                //    rbody.AddForce(new Vector2(-throwX, throwY), ForceMode2D.Impulse);
                //}
                //else
                //{
                //    rbody.AddForce(new Vector2(throwX, throwY), ForceMode2D.Impulse);
                //}
            }
        }
        else
        {
            pushFlag = false;
        }
    }

    void Dt()
    {
        Destroy(gameObject);
    }
}
