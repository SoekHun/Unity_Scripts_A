using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_ChaseCamera : MonoBehaviour
{

    void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.z = -10;
        Camera.main.gameObject.transform.position = pos;
    }
}
