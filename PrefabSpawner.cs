using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    private float nextSpawnTime;

    [SerializeField]
    public GameObject spawnPrefab;
    [SerializeField]
    public float spawnDelay = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
       if (ShouldSpawn())
        {
            Spawn();
        } 
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(spawnPrefab, transform.position, transform.rotation);
    }

   

}
