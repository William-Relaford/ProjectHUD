using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health = 2;
    private float dazedtime;
    public float startDazedtime;
    private object speed;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(health <= 0)
        {
            Destroy(gameObject);   
        }
        if(dazedtime <= 0)
        {
            speed = 5;
        }
        else
        {
            speed = 0;
            dazedtime -= Time.deltaTime;
        }
    }
      public void TakeDamage(int damage)
      {
        dazedtime = startDazedtime;
      } 
      public GameObject drop;//coin
      private void OnDestroy()//called, when enemy will be destroyed 
      {
        Instantiate(drop, transform.position, drop.transform.rotation);// you dropped a coin
      }

   
}
