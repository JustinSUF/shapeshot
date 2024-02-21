using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public float speed;
    public int damage;
    PlayerHealth playerHealth;
    public float SecondsTillDestroy;

    // Start is called before the first frame update
    
    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        Vector2 targetPos = GameObject.FindGameObjectWithTag("Player").transform.position - this.transform.position;
        this.GetComponent<Rigidbody2D>().velocity = targetPos * speed;
        StartCoroutine(waiter());
    }


    
    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            playerHealth.TakeDamage(damage);
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(SecondsTillDestroy);
        Object.Destroy(this.gameObject);
    }
}
