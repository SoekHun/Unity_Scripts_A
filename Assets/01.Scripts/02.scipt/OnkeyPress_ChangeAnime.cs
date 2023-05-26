using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnkeyPress_ChangeAnime : MonoBehaviour
{
    // 키를 누르면 애니메이션을 전환한다
    public string upAnime = "";
    public string downAnime = "";
    public string rightAnime = "";
    public string leftAnime = "";

    string nowMode = "";
    void Start()
    {
        nowMode = downAnime;
    }

    void Update()
    {
        if(Input.GetKeyDown("up"))
        {
            nowMode = upAnime;
        }
        if (Input.GetKeyDown("down"))
        {
            nowMode = downAnime;
        }
        if (Input.GetKeyDown("right"))
        {
            nowMode = rightAnime;
        }
        if (Input.GetKeyDown("left"))
        {
            nowMode = leftAnime;
        }
    }

    void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);    
    }
}

