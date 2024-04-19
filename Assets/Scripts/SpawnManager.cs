using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject _battleField;
    [SerializeField] GameObject _playerPrefab;
    [SerializeField] GameObject _enemyPrefab;
    [SerializeField] int _spawnRange = 3;

    private void Start() {
        Spawn(_battleField, Vector3.zero, 1.0f);
        Spawn(_playerPrefab, GenerateSpawnPosition(), 2.0f);
        Spawn(_enemyPrefab, GenerateSpawnPosition(), 3.0f);
    }

    private void Spawn(GameObject prefab, Vector3 spawnPosition, float delay) {
        StartCoroutine(SpawnWithDelay(prefab, spawnPosition, delay));
    }

    private IEnumerator SpawnWithDelay(GameObject prefab, Vector3 position, float delay) {
        yield return new WaitForSeconds(delay);
        Instantiate(prefab, position, prefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition() {
        float spawnPosX = Random.Range(-_spawnRange, _spawnRange);
        float spawnPosZ = Random.Range(-_spawnRange, _spawnRange);
        return new Vector3(spawnPosX, 2, spawnPosZ);
    }
}
