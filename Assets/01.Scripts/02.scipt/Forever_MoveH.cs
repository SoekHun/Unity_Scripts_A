using System.Collections; 
using System.Collections.Generic;       // <...> ���� ��ü�� ���� ��
using UnityEngine;

public class Forever_MoveH : MonoBehaviour // ����� �ް� �ִ� ����(���ϸ��� �����ؾ� �Ѵ�)
{
    public float speed = 1.0f;

    public void FixedUpdate()
    {
        transform.Translate(speed / 50, 0, 0);
    }
}
