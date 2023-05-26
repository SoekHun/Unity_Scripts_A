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

    //���Զ� ĳ���Ͱ� �浹�� �Ǿ��� �� ȣ��Ǵ� �Լ�(������ ���� ����)
    void OnCollisionEnter2D(Collision2D collision) //Collision�� ǫ������ ���� x
    {
      if(collision.gameObject.name == targetObjectName)
        {
            Vector3 pos = showObject.transform.position;
            pos.y = orgY;
            showObject.transform.position = pos;
        }
    }

}
