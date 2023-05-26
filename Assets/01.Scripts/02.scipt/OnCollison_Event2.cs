using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollison_Event2 : MonoBehaviour
{
    public string targetObjectName;
    public GameObject Gob;

    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 1f;
            Gob.SetActive(false);
        }

    }
}
