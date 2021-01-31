using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float timeToSpawn;

    private float currentTimeToSpawn;

    public void SpawnToObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
           
            currentTimeToSpawn = timeToSpawn;

        }


    }

 

 
}
