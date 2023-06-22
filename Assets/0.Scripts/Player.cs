using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public bool   isStart = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Door")
        {
            GameObject.Find("DoorAnimation").GetComponent<Animator>().SetTrigger("open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Door")
        {
            GameObject.Find("DoorAnimation").GetComponent<Animator>().SetTrigger("close");
        }

        if(other.name == "Line")
        {
            isStart = true;
        }

        if(other.GetComponent<Wood>())
        {
            other.GetComponent<CapsuleCollider>().isTrigger = false;
            Vector3 vec = transform.position;
            vec.x = -1;
            transform.position = vec;
            Destroy(other.GetComponent<CapsuleCollider>());
            other.GetComponent<CapsuleCollider>().isTrigger = true;

        }
        
    }

    public void Dead()
    {
        GetComponent<SimpleSampleCharacterControl>().m_moveSpeed = 0;
        GetComponent<Animator>().SetTrigger("Wave");
    }
}
