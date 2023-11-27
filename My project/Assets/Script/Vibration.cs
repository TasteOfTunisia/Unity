using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VibratePhone()
    {
        // Check if the platform supports vibration
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            // Vibrate for 500 milliseconds
            Handheld.Vibrate();
        }
        else
        {
            Debug.LogWarning("Vibration not supported on this platform.");
        }
    }
}
