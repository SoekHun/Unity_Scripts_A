using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Cont : MonoBehaviour
{
    [SerializeField] List<Wood> trans;

    float spawnTime;
    float Timer;

    float speedCount = 3f;
    int count = 0;
    int nextCount = 1;
    float speed = 5f;
    void Start()
    {
        InvokeRepeating("Spawnwood", 2f, Random.Range(0, 3f));
    }

    void Spawnwood()
    {
        Wood wood = Instantiate(trans[Random.Range(0, trans.Count)], transform);
        wood.speed =  speedCount;
        count++;
        if(count > nextCount)
        {
            CancelInvoke("Spawnwood");
            count = 0;
            nextCount = Random.Range(2, 6);
            speed--;
            InvokeRepeating("Spawnwood", 2f, Random.Range(0, 3f));
        }
    }
    // Update is called once per frame
}
