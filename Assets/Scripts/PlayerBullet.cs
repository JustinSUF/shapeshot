using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    public int damage;
    AiDamage enemyHealth;
    public float SecondsTillDestroy;



    // Start is called before the first frame update
    void Awake()
    {
        enemyHealth = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AiDamage>();
        this.GetComponent<Rigidbody2D>().velocity = GameObject.FindGameObjectWithTag("Player").transform.up * speed;
        StartCoroutine(waiter());

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyHealth.EDamage(damage);
            Destroy(this.gameObject);
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(SecondsTillDestroy);
        Object.Destroy(this.gameObject);
    }
}

