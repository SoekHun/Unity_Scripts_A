using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineChaser : MonoBehaviour
{
    [SerializeField] Transform EndLine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 0.3f; // ���� ������ �̵� �ӵ�

        // EndLine���� ���ݾ� �̵�
        transform.position = Vector3.MoveTowards(transform.position, EndLine.position, moveSpeed * Time.deltaTime);
    }
}

