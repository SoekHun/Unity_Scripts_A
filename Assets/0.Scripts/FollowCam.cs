using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = target.position;
        pos.x = target.position.x -3f;
        pos.y = target.position.y + 3.1f;
        pos.z = target.position.z;
        transform.position = Vector3.Lerp(target.position, pos, 1f);
    }
}
