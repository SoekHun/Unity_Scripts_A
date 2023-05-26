using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newThrow : MonoBehaviour
{
    public GameObject prefab; // ������ ������
    public float delay = 0.83f; // ���� ���� �ð�

    private bool canSpawn = true; // ���� �������� ����

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            StartCoroutine(SpawnPrefabWithDelay());
        }
    }

    private IEnumerator SpawnPrefabWithDelay()

    {
        canSpawn = false; // ���� �Ұ����� ���·� ����

        // �ð����� �ΰ� ������ ����
        GameObject newGameObject = Instantiate(prefab, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(delay);

        canSpawn = true; // �ٽ� ���� ������ ���·� ����
    }
    }
