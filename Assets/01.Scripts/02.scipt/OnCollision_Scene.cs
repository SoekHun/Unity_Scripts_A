using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_Scene : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;
    
    void Start()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }



}
