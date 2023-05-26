using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newThrow : MonoBehaviour
{
    public GameObject prefab; // 생성할 프리팹
    public float delay = 0.83f; // 생성 간격 시간

    private bool canSpawn = true; // 생성 가능한지 여부

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            StartCoroutine(SpawnPrefabWithDelay());
        }
    }

    private IEnumerator SpawnPrefabWithDelay()

    {
        canSpawn = false; // 생성 불가능한 상태로 변경

        // 시간차를 두고 프리팹 생성
        GameObject newGameObject = Instantiate(prefab, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(delay);

        canSpawn = true; // 다시 생성 가능한 상태로 변경
    }
    }
