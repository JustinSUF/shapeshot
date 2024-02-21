using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3.5f, 3f);
    }

    public void Spawn()
    {
        float randomY = Random.Range(4.64f,-4.83f);

        GameObject REnemy = enemy[Random.Range(0, enemy.Length)];

        Instantiate(REnemy, new Vector2(-9.64f, randomY), REnemy.transform.rotation);
    }
}