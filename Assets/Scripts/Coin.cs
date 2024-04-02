using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class Coin : MonoBehaviour
{
    public static event Action OnCoinCollected; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Steve"))
        {
            if (OnCoinCollected != null)
            {
                OnCoinCollected(); 
            }
            Destroy(gameObject);
        }
    }
}
