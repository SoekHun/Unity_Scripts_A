using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���ӽ����̽� �߰�

public class OnMouseDown_switchScene : MonoBehaviour
{
    public string sceneName;
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }

  
    
}
