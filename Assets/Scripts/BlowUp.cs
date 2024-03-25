using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowUp : MonoBehaviour
{
    AudioSource Audio;

    private void Start()
    {
        Audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
        audioSource = Audio;
    }
    public AudioSource audioSource;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
        Destroy(this.gameObject);
        audioSource.Play();
        }
       


    }


}
