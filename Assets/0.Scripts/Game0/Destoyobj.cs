using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyobj : MonoBehaviour
{
    [SerializeField] public GameObject[] tilePrefabs; // 타일 프리팹 배열

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
        yield return new WaitForSeconds(2f); // 2초 대기

        // 현재 게임 오브젝트의 위치에서 x값을 +2.5한 위치에 랜덤한 타일 생성
        int randomIndex = Random.Range(0, tilePrefabs.Length);
        GameObject newTile = Instantiate(tilePrefabs[randomIndex], transform.position + new Vector3(2.5f, 0f, 0f), Quaternion.identity);
    }

    private void OnDestroy()
    {
        Destroy(gameObject);

    }
}
