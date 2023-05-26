using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollison_Event : MonoBehaviour
{
    public string targetObjectName;
    public string Gobname;

    GameObject Gob;
    void Start()
    {
        Gob = GameObject.Find(Gobname);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 10f;
            Gob.SetActive(false);
        }

    }
}
