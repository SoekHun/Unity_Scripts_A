using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollView_UI : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    [SerializeField] private Transform parent;
    
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Instantiate(Prefab, parent);
        }    
    }

    
}
