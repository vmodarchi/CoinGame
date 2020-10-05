using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _coinPrefab;
    [SerializeField]
    private GameObject _enemyPrefab;

    private float x = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector3 coinSpawnPos = new Vector3(Random.Range(-6.6f, 6.6f), -0.5f ,60f);
            Vector3 enemySpawnPos = new Vector3(Random.Range(-6.6f, 6.6f), -0.5f, 70f);
            

            Instantiate(_coinPrefab, coinSpawnPos, Quaternion.identity);
            Instantiate(_enemyPrefab, enemySpawnPos, Quaternion.identity);
            
            yield return new WaitForSeconds(1.0f);
        }
    }
    
}
