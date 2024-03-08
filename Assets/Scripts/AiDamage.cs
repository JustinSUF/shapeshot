using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AiDamage : MonoBehaviour
{
    public int damage;
    private PlayerHealth playerHealth;
    public int HealthEnemy = 25;
    public int healthEnemy;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        healthEnemy = HealthEnemy;
        
    }
  
    // Update is called once per frame
    void Update()
    {
        if (healthEnemy <= 0)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
    public void EDamage(int damage)
    {
        healthEnemy -= damage;
    }
}
