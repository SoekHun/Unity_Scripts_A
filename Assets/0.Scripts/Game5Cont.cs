using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Game5Cont : MonoBehaviour
{
    [SerializeField] public Player p;
    string[] strs = { "0", "1", "2", "3", "4", "5..", "6..", "7...!", "8!!", };
    string curStr;
    public TMP_Text txt;
    int strindex = 0;
    float curTimer;
    float strDelayTime = 0f;
    int waitTimer = 5;

    bool isStart = false;
    bool isPause = false;

    Vector3 PStopos;
    void Start()
    {
        waitTime();
        InvokeRepeating("waitTime", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart)
            return;

        curTimer += Time.deltaTime;
        if(curTimer >= strDelayTime)
        {
            curTimer = 0f;
            curStr = strs[strindex];
            txt.text = curStr;
            strindex++;

            if(strindex >= strs.Length)
            {
                strindex = 0;
                strDelayTime = Random.Range(1f, 3f);
                isPause = true;
                PStopos = p.transform.position;
                
            }
            else
            {
                strDelayTime = Random.Range(.1f, .6f);
                isPause = false;
            }         
        }

        if(isPause) 
        {
            if(PStopos != p.transform.position) 
            {
                isPause = false;
                p.Dead();
            }
        }
    }

    void waitTime()
    {

        waitTimer--;
        txt.text = $"8sec you must be stop\nGame ready : {waitTimer} sec... ";
        if(waitTimer <= 0)
        {
            isStart = true;
            CancelInvoke();

            if(!p.isStart)
            {
                p.Dead();
            }
        }
    }
}
