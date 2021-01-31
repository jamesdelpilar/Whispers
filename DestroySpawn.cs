using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag("Destroyer"))
        //{
        //    Debug.Log("It Works!");
        //    Destroy(collision.gameObject);
        //}

        player.transform.position = respawnPoint.transform.position;


    
    }


}
