using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classic_Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x =Input.GetAxisRaw("Horizontal") * Time.deltaTime * 10f;
        float y = Input.GetAxisRaw("Vertical") * Time.deltaTime * 10f;
        transform.Translate(x, y, 0f);
    }
}
