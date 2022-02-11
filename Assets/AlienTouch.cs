using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AlienTouch : MonoBehaviour
{
    [SerializeField] Camera hiddenItems;
    [SerializeField] GameObject hidden;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hiddenItems.backgroundColor = Color.red;
            hidden.SetActive(true);
        }
    }
}
