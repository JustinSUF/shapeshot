using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowUp : MonoBehaviour
{
    public AudioClip soundToPlay;
    private AudioSource audioSource;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        audioSource.PlayOneShot(soundToPlay);
    }


}
