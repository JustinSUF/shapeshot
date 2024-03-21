using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public GameObject RespawnPlayer;
    public GameObject player;

    private float boundary = 13.4f;
    private float boundrayY = 7.5f;

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

    private void Update()
    {
        if (transform.position.x > boundary)
        {
            transform.position = new Vector2(boundary,transform.position.y);
        }

        if (transform.position.x < -boundary)
        {
            transform.position = new Vector2(-boundary, transform.position.y);
        }

        if (transform.position.y < -boundrayY)
        {
            transform.position = new Vector2(transform.position.x, -boundrayY);
        }

        if (transform.position.y > boundrayY)
        {
            transform.position = new Vector2(transform.position.x, boundrayY);
        }
    }
}
