using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveV : MonoBehaviour
{
    public float speed = 1.0f;

    public void FixedUpdate()
    {
        transform.Translate(0, speed / 50, 0);
    }
}
