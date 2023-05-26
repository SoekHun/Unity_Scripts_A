using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMultiCollison_Show : MonoBehaviour
{
    public string targetObjectName;
    public string showObjectName;

    private GameObject showObject;

    private float orgY = 0;
    private float offsetY = 10000;
    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        orgY = showObject.transform.position.y;
        if(orgY > offsetY)
        {
            orgY -= offsetY;
        }
        Vector3 pos = showObject.transform.position;
        pos.y = orgY + offsetY;
        showObject.transform.position = pos;
    }

    //성게랑 캐릭터가 충돌이 되었을 때 호출되는 함수(물리적 현상 있음)
    void OnCollisionEnter2D(Collision2D collision) //Collision은 푹빠지는 현상 x
    {
      if(collision.gameObject.name == targetObjectName)
        {
            Vector3 pos = showObject.transform.position;
            pos.y = orgY;
            showObject.transform.position = pos;
        }
    }

}
