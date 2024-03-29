using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    public AudioClip buttonSFX;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    public void PlaySFX()
    {
        audioSource.PlayOneShot(buttonSFX);
    }
}
