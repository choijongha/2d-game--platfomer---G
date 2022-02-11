using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointChange : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] Transform player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            spawnPoint.transform.position = player.position;
        }
         
    }
}
