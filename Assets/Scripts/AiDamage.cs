using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AiDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;
    public int HealthEnemy = 25;
    public int healthEnemy;

    // Start is called before the first frame update
    void Start()
    {
        healthEnemy = HealthEnemy;
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
