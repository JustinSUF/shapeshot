using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public GameObject RespawnPlayer;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            player.transform.position = RespawnPlayer.transform.position;
            health = maxHealth;
        }
    }
}
