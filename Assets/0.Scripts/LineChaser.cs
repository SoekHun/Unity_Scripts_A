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
        float moveSpeed = 0.3f; // 조절 가능한 이동 속도

        // EndLine으로 조금씩 이동
        transform.position = Vector3.MoveTowards(transform.position, EndLine.position, moveSpeed * Time.deltaTime);
    }
}

