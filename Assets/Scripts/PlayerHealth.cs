using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public GameObject RespawnPlayer;
    public GameObject player;

    public Sprite normalSprite; // Reference to the normal sprite
    public Sprite damageSprite; // Reference to the sprite to switch to when taking damage
    public float switchDuration = 0.5f; // Duration to switch to damage sprite (in seconds)

    private float boundary = 13.4f;
    private float boundrayY = 7.5f;

    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HealthUp")
        {
            health = health + 5;
        }

    }
    public void TakeDamage(int damage)
    {
        StartCoroutine(FlashSprite()); // Start coroutine to flash sprite
        health -= damage;

        if (health <= 0)
        {
            player.transform.position = RespawnPlayer.transform.position;
            health = maxHealth;
        }
    }

    private IEnumerator FlashSprite()
    {
        spriteRenderer.sprite = damageSprite; // Switch to damage sprite
        yield return new WaitForSeconds(switchDuration); // Wait for switch duration
        spriteRenderer.sprite = normalSprite; // Switch back to normal sprite
    }

    private void Update()
    {
        if (transform.position.x > boundary)
        {
            transform.position = new Vector2(boundary, transform.position.y);
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
