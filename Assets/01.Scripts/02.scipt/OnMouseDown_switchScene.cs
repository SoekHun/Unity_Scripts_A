using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //네임스페이스 추가

public class OnMouseDown_switchScene : MonoBehaviour
{
    public string sceneName;
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }

  
    
}
