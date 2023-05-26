using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Show : MonoBehaviour
{
    public string targetObjectName;

    public string showObjectName;

    private GameObject showObject;

    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetObjectName)
        {
            Debug.Log("targetName");
            showObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
