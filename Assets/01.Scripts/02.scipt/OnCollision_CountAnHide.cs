using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_CountAnHide : MonoBehaviour
{
    public string targetobjectName; // 공주이름
    public int addvalue = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetobjectName)
        {
            GameCounter.value = GameCounter.value + addvalue; // 점수 1를 증가
            this.gameObject.SetActive(false); // 스파게티를 안보이게끔 한다.
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
