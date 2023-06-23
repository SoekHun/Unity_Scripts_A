using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileOn : MonoBehaviour
{
    [SerializeField] public GameObject[] tilePrefabs; // Ÿ�� ������ �迭

    private void Start()
    {
        StartCoroutine(SpawnTileAfterDelay());
    }

    private IEnumerator SpawnTileAfterDelay()
    {
        yield return new WaitForSeconds(2f); // 2�� ���

        // ���� ���� ������Ʈ�� ��ġ���� x���� +2.5�� ��ġ�� ������ Ÿ�� ����
        int randomIndex = Random.Range(0, tilePrefabs.Length);
        GameObject newTile = Instantiate(tilePrefabs[randomIndex], transform.position + new Vector3(2.5f, 0f, 0f), Quaternion.identity);
    }

}
