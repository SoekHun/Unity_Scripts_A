using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Follow : MonoBehaviour
{
    public Transform TargetTransform;
    Vector2 refVelocity;

    public float Sspeed = 1.0f;
    //public float Gsize = 2f;
    
    void FixedUpdate()
    {
        if (TargetTransform != null)
        {
            transform.position = Vector2.SmoothDamp(transform.position,
                TargetTransform.position, ref refVelocity, Sspeed);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        //Gizmos.DrawWireCube(transform.position.normalized, Vector3.one * Gsize);
    }
}
