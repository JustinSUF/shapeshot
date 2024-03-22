using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
    public AudioClip soundToPlay;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found. Please attach an AudioSource to the GameObject.");
            enabled = false; // Disable the script if there's no AudioSource
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 represents the left mouse button
        {
            if (soundToPlay != null)
            {
                audioSource.PlayOneShot(soundToPlay);
            }
            else
            {
                Debug.LogWarning("No audio clip assigned to play.");
            }
        }
    }
}
