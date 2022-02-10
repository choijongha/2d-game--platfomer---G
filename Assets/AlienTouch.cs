using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienTouch : MonoBehaviour
{
    [SerializeField] GameObject hiddenItems;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hiddenItems.SetActive(true);
        }
    }
}
