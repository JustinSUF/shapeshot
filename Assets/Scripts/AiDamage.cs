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

    float switchDuration = 0.1f; // Duration to switch to damage sprite (in seconds)
    int numberflashes = 3;

    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        healthEnemy = HealthEnemy;
        
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
       
    }
    public void EDamage(int damage)
    {
        healthEnemy -= damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
            playerHealth.TakeDamage(damage);
            StartCoroutine(FlashRed());
            
        }
        if(collision.gameObject.tag == "PlayerBullet")
        {
            StartCoroutine(FlashRed());
        }
    }
    IEnumerator FlashRed()
    {

            GetComponent<SpriteRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(switchDuration);
            GetComponent<SpriteRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<SpriteRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<SpriteRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<SpriteRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<SpriteRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<SpriteRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(switchDuration);
        GetComponent<SpriteRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(switchDuration);
    }


 
}
