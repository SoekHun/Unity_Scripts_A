using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnkeyPress_ChangeAnime : MonoBehaviour
{
    // Ű�� ������ �ִϸ��̼��� ��ȯ�Ѵ�
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

