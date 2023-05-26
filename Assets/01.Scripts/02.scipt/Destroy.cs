using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject mon;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("prefab"))
        {
            
            // 충돌한 오브젝트를 파괴
            Destroy(other.gameObject);
        }

    }

    
}
