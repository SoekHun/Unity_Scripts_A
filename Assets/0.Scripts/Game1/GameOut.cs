using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OntriggernEnter(Collider other)
    {
        if(GameObject.FindWithTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("게임오버");
        }
    }


}
