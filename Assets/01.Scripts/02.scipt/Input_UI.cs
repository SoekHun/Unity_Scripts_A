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
        Debug.Log("id´Â lsh\n pw´Â 123!@#ÀÔ´Ï´Ù");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChangeID()
    {
        string Check = Regex.Replace(idField.text, @"[^a-zA-z0-9°¡-ÆR]", "", RegexOptions.Singleline);
    }

    public void OnValueChangePW()
    {

    }

    public void OnSend()
    {
        if(!IsIDCheck())
        {
            Debug.Log("¾ÆÀÌµð°¡ Àß¸øµÆ´Ù");
            return;
        }
            
        if(!IsPWCheck())
        {
            Debug.Log("ºñ¹Ð¹øÈ£°¡ Àß¸øµÆ´Ù");
            return;
        }
        Debug.Log("¼º°ø");
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
