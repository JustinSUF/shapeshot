using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;
    public int damage;
    PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        Vector2 targetPos = GameObject.FindGameObjectWithTag("Player").transform.position - this.transform.position;
        this.GetComponent<Rigidbody2D>().velocity = targetPos * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            playerHealth.TakeDamage(damage);
        }
    }
}
