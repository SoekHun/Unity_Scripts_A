using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_RandomCreatPrefab : MonoBehaviour
{
    public GameObject newPrefab;
    [SerializeField] Transform spawnPos;
    public float intervalSec = 1;
    
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(newPrefab, spawnPos);
        }
        //�Լ���(�Լ� ������) ���� �Ŀ� ȣǮ �� ���ΰ�, ��� ȣ���� ���ΰ�
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    
    void CreatePrefab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
        Vector3 newPos = transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = -5;

        //GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        GameObject newGameObject = (GameObject)Instantiate(newPrefab);
        newGameObject.transform.position = newPos;

    }
}
