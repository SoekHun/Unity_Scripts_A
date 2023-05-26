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
        Debug.Log("id�� lsh\n pw�� 123!@#�Դϴ�");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChangeID()
    {
        string Check = Regex.Replace(idField.text, @"[^a-zA-z0-9��-�R]", "", RegexOptions.Singleline);
    }

    public void OnValueChangePW()
    {

    }

    public void OnSend()
    {
        if(!IsIDCheck())
        {
            Debug.Log("���̵� �߸��ƴ�");
            return;
        }
            
        if(!IsPWCheck())
        {
            Debug.Log("��й�ȣ�� �߸��ƴ�");
            return;
        }
        Debug.Log("����");
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
