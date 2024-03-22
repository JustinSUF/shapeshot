using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMoving : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float speed = 5f;
    
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        Vector2 targetPos = GameObject.FindGameObjectWithTag("Player").transform.position - this.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        transform.up = player.transform.position - transform.position;
    }


}

