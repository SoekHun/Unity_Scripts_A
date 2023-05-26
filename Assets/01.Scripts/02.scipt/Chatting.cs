using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class Chatting : MonoBehaviour
{
    [SerializeField] private GameObject[] item;
    [SerializeField] private Transform parent;

    [SerializeField] private TMP_InputField inputField;
    [SerializeField] float randomChattingTimer;

    string myNickname = "SeokHun";
    string[] randomNicknames;
    void Start()
    {
        randomNicknames = new string[] {
            "wqe" ,  "rogkro   " ,
            "bpplb" ,  "feorm" ,
            "kgmfd" ,  "fie      " ,
            "rpqwvub  " ,  "vkuqhaq  " ,
            "vjkdsnvq " ,  "sldif" ,
            "esoifj" ,  "pwqoei" ,
            "lsakjc" ,  "asodkjawd" ,
            "dsoojca "  ,    "p9uvahas " ,
            "pdioqw" ,  "dowqi    " ,
            "pdqiwo   ",   "qwr      " ,
            "rqw" ,  "fsdA     " ,
            "WQR" ,  "FADVS    " ,
            "wef" ,  "ihnsf" ,
            "fdosfo   " ,  "dsfkvmnm " ,
            "dsmvo" ,  "wokwq" ,
            "rqwoofm  " ,  "qwofmcoq " ,
            "lskamkl  " ,  "daslkmc  " ,
            "dsd" ,  "smov" ,
            "dksmdwo" ,  "dwlmlg   "
            
    };
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        { OnEndChatting(myNickname, inputField.text); }

        randomChattingTimer += Time.deltaTime;
        if(randomChattingTimer > 2f ) 
        {
            randomChattingTimer = 0;
            OnEndChatting(randomNicknames[Random.Range(0, randomNicknames.Length)], "아무거나");
           
        }
    }

    public void OnEndChatting(string nick, string txt)
    {
        if (string.IsNullOrEmpty(txt))
            return;
        

        GameObject obj = Instantiate(item[0], parent);
        obj.GetComponent<TMP_Text>().text = $"[{myNickname}] : {inputField.text}";
        inputField.text = string.Empty;
        inputField.Select();
    }
}
