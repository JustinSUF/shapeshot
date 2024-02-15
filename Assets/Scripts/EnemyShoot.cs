using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 10;
    private float timeWhenAllowedNextShoot = 0f;
    private float timeBetweenShooting = 10f;


    
    void Update()
    {
        checkIfShouldShoot();
    }

    void checkIfShouldShoot()
    {
        if (timeWhenAllowedNextShoot <= Time.time)
        {
           
                shoot();
                timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void shoot()
    {
        var bullet= Instantiate(bulletPrefab,bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.localPosition * bulletspeed;
        
    }
}
