using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_CountAnHide : MonoBehaviour
{
    public string targetobjectName; // �����̸�
    public int addvalue = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetobjectName)
        {
            GameCounter.value = GameCounter.value + addvalue; // ���� 1�� ����
            this.gameObject.SetActive(false); // ���İ�Ƽ�� �Ⱥ��̰Բ� �Ѵ�.
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
