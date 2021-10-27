using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _enemyPrefab = null;

    private GameObject enemyPrefab { get { return _enemyPrefab; } } //set { _enemyPrefab = value; } }

    public float _spawnDelay = 0.5f;

    private float spawnDelay { get { return _spawnDelay; } }

    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnDelay);
    }
    private void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.z += Random.Range(-0.3f, 0.3f);
        Instantiate(enemyPrefab, spawnPosition, transform.rotation);
    }

    void Update()
    {
        
    }
}
