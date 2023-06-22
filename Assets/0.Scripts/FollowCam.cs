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
        pos.x = target.position.x;
        pos.y = target.position.y + 1.7f;
        pos.z = target.position.z - 3f;
        transform.position = Vector3.Lerp(target.position, pos, 1f);
    }
}
