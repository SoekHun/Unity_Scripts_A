using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;

public class Input_UI : MonoBehaviour
{
    [SerializeField] private TMP_InputField idField;
    [SerializeField] private TMP_InputField pwField;
    public string SceneName;

    string id = "lsh";
    string pw = "123!@#";
    void Start()
    {
        Debug.Log("id는 lsh\n pw는 123!@#입니다");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChangeID()
    {
        string Check = Regex.Replace(idField.text, @"[^a-zA-z0-9가-힣]", "", RegexOptions.Singleline);
    }

    public void OnValueChangePW()
    {

    }

    public void OnSend()
    {
        if(!IsIDCheck())
        {
            Debug.Log("아이디가 잘못됐다");
            return;
        }
            
        if(!IsPWCheck())
        {
            Debug.Log("비밀번호가 잘못됐다");
            return;
        }
        Debug.Log("성공");
        SceneManager.LoadScene(SceneName);
        
    }

    public bool IsIDCheck()
    {
        if (idField.text == id)
        return true;
        return false;
    }

    public bool IsPWCheck()
    {
        if (pwField.text == pw)
            return true;
        return false;
    }
    

}
