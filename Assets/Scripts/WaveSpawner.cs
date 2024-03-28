using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject[] boostup;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3.5f, 3f);
        InvokeRepeating("boost", 30f, 30f);
    }

    public void Spawn()
    {
        float randomY = Random.Range(7.14f, -7.14f);
        float randomXX = Random.Range(13.4f, -13.4f);

        GameObject REnemy = enemy[Random.Range(0, enemy.Length)];

        Instantiate(REnemy, new Vector2(randomXX, randomY), REnemy.transform.rotation);
    }

    public void boost()
    {
        float randomYY = Random.Range(7.14f, -7.14f);
        float randomX = Random.Range(13.4f,-13.4f);

        GameObject BBoost = boostup[Random.Range(0, boostup.Length)];

        Instantiate(BBoost, new Vector2(randomX, randomYY), BBoost.transform.rotation);
    }
}

