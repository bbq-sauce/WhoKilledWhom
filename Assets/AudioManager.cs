using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip mobileOpenClip;
    public AudioClip mobileCloseClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MobileOpenSound()
    {
        audioSource.PlayOneShot(mobileOpenClip);
    }

    public void MobileCloseSound()
    {
        audioSource.PlayOneShot(mobileCloseClip);
    }
}
