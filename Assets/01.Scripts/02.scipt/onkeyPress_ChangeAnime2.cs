using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onkeyPress_ChangeAnime2 : MonoBehaviour
{

    public string upAnime = "";
    public string downAnime = "";
    public string rightAnime = "";
    public string leftAnime = "";


    string nowMode = "";
    string oldMode = "";
    void Start()
    {
        nowMode = downAnime;
        oldMode = "";
    }

    void Update()
    {
        if(Input.GetKey("up"))
        {
            nowMode = upAnime;
        }
        if (Input.GetKey("down"))
        {
            nowMode = downAnime;
        }
        if (Input.GetKey("right"))
        {
            nowMode = rightAnime;
        }
        if (Input.GetKey("left"))
        {
            nowMode = leftAnime;
        }
     
    }
    void FixedUpdate()
    {
        if (nowMode != oldMode)
        {
            oldMode = nowMode;
            Animator animator = GetComponent<Animator>();
            animator.Play(nowMode); //Animation Clip Play
        }
    }
}
