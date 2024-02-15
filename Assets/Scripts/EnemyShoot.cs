using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        Instantiate(bulletPrefab,bulletSpawnPoint.position,bulletPrefab.transform.rotation);
        
    }
}
