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
        //Vector2 targetPos = player.transform.position - this.transform.position;
        transform.up = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
   
}

