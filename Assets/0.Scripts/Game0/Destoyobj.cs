using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyobj : MonoBehaviour
{
    [SerializeField] public GameObject[] tilePrefabs; // Ÿ�� ������ �迭

    void Start()
    {
        StartCoroutine(SpawnTileAfterDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        Invoke("OnDestroy", 0.3f);
        
    }

    private IEnumerator SpawnTileAfterDelay()
    {
        yield return new WaitForSeconds(2f); // 2�� ���

        // ���� ���� ������Ʈ�� ��ġ���� x���� +2.5�� ��ġ�� ������ Ÿ�� ����
        int randomIndex = Random.Range(0, tilePrefabs.Length);
        GameObject newTile = Instantiate(tilePrefabs[randomIndex], transform.position + new Vector3(2.5f, 0f, 0f), Quaternion.identity);
    }

    private void OnDestroy()
    {
        Destroy(gameObject);

    }
}
