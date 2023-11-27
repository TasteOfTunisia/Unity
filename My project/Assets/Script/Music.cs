using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject mainCamera; // Reference to the main camera GameObject

    // Start is called before the first frame update
    void Start()
    {
        // Try to get the AudioSource component from the main camera
        if (mainCamera != null)
        {
            AudioSource audioSource = mainCamera.GetComponent<AudioSource>();

            // If it's still null, log an error
            if (audioSource == null)
            {
                Debug.LogError("AudioSource component not found on the main camera!");
            }
            else
            {
                audioSource.Play();
                audioSource.Pause();
            }
        }
        else
        {
            Debug.LogError("Main camera GameObject not assigned in the inspector!");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    // Method to toggle play/pause
    public void TogglePlayPause()
    {
        if (mainCamera != null)
        {
            AudioSource audioSource = mainCamera.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Pause();
                }
                else
                {
                    audioSource.UnPause();
                }
            }
        }
    }
}
