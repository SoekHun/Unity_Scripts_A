using System.Collections; 
using System.Collections.Generic;       // <...> 같은 객체를 만들 때
using UnityEngine;

public class Forever_MoveH : MonoBehaviour // 상속을 받고 있는 관계(파일명은 동일해야 한다)
{
    public float speed = 1.0f;

    public void FixedUpdate()
    {
        transform.Translate(speed / 50, 0, 0);
    }
}
