using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowUp : MonoBehaviour
{
   
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
